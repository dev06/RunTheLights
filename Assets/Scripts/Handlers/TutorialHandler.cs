using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialHandler : MonoBehaviour {


	public static bool ActivateTutorialCars;

	public static bool TutorialStatus = true;

	public Text tutorialText;

	public Text tutorialTitle;

	private int currentStep;

	private float pointerDownTimer;

	private float pointerUpTimer;

	private float dragTimer;

	private CanvasGroup canvasGroup;

	void OnEnable()
	{
		EventManager.OnTutorialStep += OnTutorialStep;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
		EventManager.OnShowcaseDisable += OnShowcaseDisable;
	}
	void OnDisable()
	{
		EventManager.OnTutorialStep -= OnTutorialStep;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
	}

	void OnTutorialStep(int step)
	{

	}


	void OnShowcaseEnable()
	{
		Toggle(false);
	}
	void OnShowcaseDisable()
	{
		Toggle(true);
	}

	void Toggle(bool b)
	{
		if (b)
		{
			if (!GameController.TutorialEnabled) return;
		}
		canvasGroup.alpha = b ? 1 : 0f;
		canvasGroup.blocksRaycasts = b;
	}

	void Start ()
	{

		canvasGroup = GetComponent<CanvasGroup>();

		if (GameController.TutorialEnabled)
		{
			ActivateTutorialCars = false;
			TutorialStatus = true;
		}

		Toggle(GameController.TutorialEnabled);

	}

	void Update ()
	{
		if (currentStep == 0)
		{
			if (Section.VELOCITY > 15f)
			{
				pointerDownTimer += Time.deltaTime;

				if (pointerDownTimer > 3f)
				{
					tutorialText.text = "Drag to steer the car!";
					currentStep++;
				}
			}
		}

		if (currentStep == 1)
		{

			dragTimer += Time.deltaTime;

			if (dragTimer > 7f)
			{
				tutorialText.text = "Let go to decelerate";
				currentStep++;
			}

		}

		if (currentStep == 2)
		{
			if (Section.VELOCITY <= 0)
			{
				pointerUpTimer += Time.deltaTime;

				if (pointerUpTimer > 1f)
				{
					tutorialText.text = "Avoid cars at intersection";
					TutorialHandler.ActivateTutorialCars = true;
					TutorialStatus = false;
					currentStep++;
				}
			}
		}
	}
}
