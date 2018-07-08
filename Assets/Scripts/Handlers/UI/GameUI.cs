using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : UserInterface {

	public Text scoreText;
	public Text distanceText;
	public AdditionTexts additionText;

	public override void Init()
	{
		base.Init();
		Toggle(true);
	}

	void OnEnable()
	{
		EventManager.OnUpdateUI += OnUpdateUI;
		EventManager.OnHitObject += OnHitObject;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;
	}
	void OnDisable()
	{
		EventManager.OnUpdateUI -= OnUpdateUI;
		EventManager.OnHitObject -= OnHitObject;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;
	}

	void OnHitObject()
	{
		GameController.SetScore(1 * GameController.CURRENT_ZONE);
		additionText.TriggerNextText("+" + (1 * GameController.CURRENT_ZONE));
		Haptic.Vibrate(HapticIntensity.Medium);
	}

	void OnUpdateUI()
	{
		scoreText.text = GameController.SCORE.ToString();
		scoreText.transform.GetComponent<Animation>().Play();

	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		float delay = 0f;
		switch (type)
		{
			case ProgressionColliderType.Intersection:
			{
				additionText.TriggerNextText("+" + (5 * GameController.CURRENT_ZONE)  + " Ran Light!", new Color(1f, .5f, .5f, 1f));
				GameController.SetScore(5);
				delay = .06f;
				break;
			}

			case ProgressionColliderType.Zone:
			{
				additionText.TriggerNextText("+" + (10 * GameController.CURRENT_ZONE) +  " Zone Complete ",  new Color(.5f, .5f, 1f, 1f));
				GameController.SetScore(10);
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

	void Update()
	{
		distanceText.text = GameController.DISTANCE_TRAVELED.ToString("F0") + "m";
	}
}
