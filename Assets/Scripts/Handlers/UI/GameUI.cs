using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : UserInterface {

	public Text furyPop;
	public Text scoreText;
	public Text distanceText;
	public AdditionTexts additionText;
	public LevelProgression levelProgression;
	private bool isToggled;
	private bool disableAdditionalTexts;

	public override void Init()
	{
		base.Init();
		Toggle(false);
		scoreText.text = GameController.SESSION_SCORE.ToString();
	}

	void OnEnable()
	{
		EventManager.OnUpdateUI += OnUpdateUI;

		EventManager.OnHitObject += OnHitObject;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;

		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnFuryStatus += OnFuryStatus;
	}
	void OnDisable()
	{
		EventManager.OnUpdateUI -= OnUpdateUI;

		EventManager.OnHitObject -= OnHitObject;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;

		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnFuryStatus -= OnFuryStatus;
	}

	void OnHitObject()
	{
		if (!isToggled)
		{
			Toggle(true);

			if (EventManager.OnGameStart != null)
			{
				EventManager.OnGameStart();
			}

		}

		if (FuryHandler.InFury)
		{
			GameController.SetScore(1 * GameController.CURRENT_ZONE);

			additionText.TriggerNextText("+" + (1 * GameController.CURRENT_ZONE));
		}

		if (FuryHandler.InFury)
		{
			Haptic.Vibrate(HapticIntensity.Medium);

		}
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
			furyPop.transform.GetComponent<Animation>().Play();
		}
	}

	void OnUpdateUI()
	{
		scoreText.text = GameController.SESSION_SCORE.ToString();
		scoreText.transform.GetComponent<Animation>().Play();

	}

	void OnLevelComplete()
	{
		levelProgression.UpdateUI();
		disableAdditionalTexts = true;
	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (disableAdditionalTexts) return;
		if (GameController.TutorialEnabled) return;
		float delay = 0f;
		switch (type)
		{
			case ProgressionColliderType.Intersection:
			{
				int multiplier = FuryHandler.InFury ? 2 : 1;
				additionText.TriggerNextText("+" + (LevelController.LEVEL * multiplier)  + " Ran Light!", new Color(1f, .5f, .5f, 1f));
				GameController.SetScore(LevelController.LEVEL * multiplier);
				delay = .06f;
				GameController.LIGHTS_RAN++;
				break;
			}

				// case ProgressionColliderType.Zone:
				// {
				// 	additionText.TriggerNextText("+" + (10 * GameController.CURRENT_ZONE) +  " Zone Complete ",  new Color(.5f, .5f, 1f, 1f));
				// 	GameController.SetScore(10 * GameController.CURRENT_ZONE);
				// 	GameController.CURRENT_ZONE++;
				// 	delay = .1f;
				// 	if (EventManager.OnZoneComplete != null)
				// 	{
				// 		EventManager.OnZoneComplete();
				// 	}
				// 	break;
				// }
		}
	}

	public override void Toggle(bool b)
	{
		if (GameController.TutorialEnabled) return;
		base.Toggle(b);
		isToggled = b;
	}

	void Update()
	{
		distanceText.text = GameController.GAME_DISTANCE.ToString("F0") + "m";
	}
}
