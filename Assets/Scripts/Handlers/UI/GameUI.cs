using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : UserInterface {

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
	}

	void OnEnable()
	{
		EventManager.OnUpdateUI += OnUpdateUI;

		EventManager.OnHitObject += OnHitObject;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;

		EventManager.OnLevelComplete += OnLevelComplete;
	}
	void OnDisable()
	{
		EventManager.OnUpdateUI -= OnUpdateUI;

		EventManager.OnHitObject -= OnHitObject;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;

		EventManager.OnLevelComplete -= OnLevelComplete;
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
		GameController.SetScore(1 * GameController.CURRENT_ZONE);
		additionText.TriggerNextText("+" + (1 * GameController.CURRENT_ZONE));
		Haptic.Vibrate(HapticIntensity.Medium);
	}

	void OnUpdateUI()
	{
		scoreText.text = GameController.GAME_SCORE.ToString();
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
		float delay = 0f;
		switch (type)
		{
			case ProgressionColliderType.Intersection:
			{
				additionText.TriggerNextText("+" + (5 * GameController.CURRENT_ZONE)  + " Ran Light!", new Color(1f, .5f, .5f, 1f));
				GameController.SetScore(5 * GameController.CURRENT_ZONE);
				delay = .06f;
				GameController.LIGHTS_RAN++;
				break;
			}

			case ProgressionColliderType.Zone:
			{
				additionText.TriggerNextText("+" + (10 * GameController.CURRENT_ZONE) +  " Zone Complete ",  new Color(.5f, .5f, 1f, 1f));
				GameController.SetScore(10 * GameController.CURRENT_ZONE);
				GameController.CURRENT_ZONE++;
				delay = .1f;
				if (EventManager.OnZoneComplete != null)
				{
					EventManager.OnZoneComplete();
				}
				break;
			}
		}
	}

	public override void Toggle(bool b)
	{
		base.Toggle(b);
		isToggled = b;
	}

	void Update()
	{
		distanceText.text = GameController.GAME_DISTANCE.ToString("F0") + "m";
	}
}
