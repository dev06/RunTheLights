using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : UserInterface {

	public Image furyPop;
	public Text scoreText;
	public Text gearsText;
	public Text durabilityText;
	public AdditionTexts additionText;
	public AdditionTexts nearMisses;
	public LevelProgression levelProgression;
	public Image damageOverlay;
	private bool isToggled;
	private bool disableAdditionalTexts;
	private Animation furyPopAnim;
	private Animation HUDAnim;
	private Animation scoreTextAnim;
	private GameInput player;
	private CameraController camera;


	private string[] furyMessages = {" Wrecked! " , " Fatality! "};

	public override void Init()
	{
		base.Init();
		Toggle(false);
		scoreText.text = GameController.SESSION_SCORE.ToString();
		furyPopAnim = furyPop.transform.GetComponent<Animation>();
		player = FindObjectOfType<GameInput>();
		camera = Camera.main.GetComponent<CameraController>();
		HUDAnim = GetComponent<Animation>();
		scoreTextAnim = scoreText.transform.GetComponent<Animation>();
	}

	void OnEnable()
	{
		EventManager.OnUpdateUI += OnUpdateUI;

		EventManager.OnHitObject += OnHitObject;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;

		EventManager.OnProgressionColliderExit += OnProgressionColliderExit;

		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnFuryStatus += OnFuryStatus;

		EventManager.OnGearTriggerHit += OnGearTriggerHit;

		EventManager.OnVehicleHit += OnVehicleHit;

		EventManager.OnGameStart += OnGameStart;

		EventManager.OnNearMiss += OnNearMiss;
	}
	void OnDisable()
	{
		EventManager.OnUpdateUI -= OnUpdateUI;

		EventManager.OnHitObject -= OnHitObject;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;

		EventManager.OnProgressionColliderExit -= OnProgressionColliderExit;

		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnFuryStatus -= OnFuryStatus;

		EventManager.OnGearTriggerHit -= OnGearTriggerHit;

		EventManager.OnVehicleHit -= OnVehicleHit;

		EventManager.OnGameStart -= OnGameStart;

		EventManager.OnNearMiss -= OnNearMiss;
	}

	bool wasNearMiss;

	void OnNearMiss()
	{
		int addition = 5;
		GameController.SetScore(addition);
		nearMisses.TriggerNextText("+" + (addition) + " Near Miss!", Color.white) ;
		wasNearMiss = true;
	}

	void OnGearTriggerHit()
	{
		gearsText.text = GameController.Instance.gearsCollected.ToString();
	}

	void OnVehicleHit()
	{
		durabilityText.text = player.VehicleDurability.ToString();

		if (FuryHandler.InFury)
		{
			TriggerChaos();

		}



		StopCoroutine("ITriggerDamageOverlay");

		StartCoroutine("ITriggerDamageOverlay");
	}

	void OnGameStart()
	{
		if (!isToggled)
		{
			Toggle(true);
		}
		durabilityText.text  = GameController.ActiveModel.durability.value.ToString();
		gearsText.text = "" + 0;
	}

	void OnHitObject()
	{
		TriggerChaos();
	}

	void OnFuryStatus(int i)
	{
		if (i == 0)
		{
			furyPop.enabled = false;
		}
		else
		{
			furyPop.enabled = true;

			furyPopAnim.Play();
		}
	}

	void OnUpdateUI()
	{
		scoreText.text = GameController.SESSION_SCORE.ToString();
		scoreTextAnim.Play();

	}

	void OnLevelComplete()
	{
		levelProgression.UpdateUI();
		disableAdditionalTexts = true;
		furyPop.transform.gameObject.SetActive(false);
	}

	bool active;

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (disableAdditionalTexts) { return; }

		if (GameController.TutorialEnabled) { return; }

		float delay = 0f;

		switch (type)
		{
			case ProgressionColliderType.Intersection:
			{
				int multiplier = FuryHandler.InFury ? 2 : 1;

				additionText.TriggerNextText("+" + (5 * multiplier)  + " Ran Light!", new Color(1f, .5f, .5f, 1f));

				GameController.SetScore(5 * multiplier);

				delay = .06f;

				if (EventManager.OnLogMapStat != null)
				{
					EventManager.OnLogMapStat(MapUnlockConditions.SpecialConditionType.RanLights, 1);
				}

				if (!wasNearMiss && !FuryHandler.InFury)
				{
					CameraController.Instance.TriggerJerk();
				}

				break;
			}
		}
	}

	void OnProgressionColliderExit(ProgressionColliderType type)
	{
		if (GameController.TutorialEnabled) { return; }

		switch (type)
		{
			case ProgressionColliderType.Intersection:
			{
				wasNearMiss = false;
				break;
			}
		}
	}







	public override void Toggle(bool b)
	{
		if (GameController.TutorialEnabled) { return; }
		base.Toggle(b);

		isToggled = b;
		if (isToggled)
		{
			HUDAnim.Play();
		}
	}

	IEnumerator ITriggerDamageOverlay()
	{
		damageOverlay.color = new Color(1, 0, 0, .75F);
		float red = damageOverlay.color.r;
		while (red >= 0)
		{
			red -= Time.deltaTime * 1.5f;
			damageOverlay.color = new Color(red, 0, 0, .75F);
			yield return null;
		}
	}

	public void TriggerChaos()
	{
		Haptic.Vibrate(HapticIntensity.Light);
		string message = FuryHandler.InFury ? furyMessages[Random.Range(0, furyMessages.Length)] : " CHAOS! ";
		additionText.TriggerNextText("+" + (5)  +  message, new Color(1f, .9f, 0F, 1f));
		GameController.SetScore(5);
		OnUpdateUI();
	}
}
