using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialHandler : MonoBehaviour {

	public static TutorialHandler Instance;

	public static bool ActivateTutorialCars;

	public static bool TutorialStatus = true;

	public Text tutorialText;

	public Image fillImage;

	private int currentStep;

	private float pointerDownTimer;

	private float pointerUpTimer;

	private float dragTimer;

	private int gearCollected;

	private CanvasGroup canvasGroup;

	private float stepProgress;

	private bool gameStarted;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			DestroyImmediate(gameObject);
		}

		if (GameController.TutorialEnabled)
		{
			ActivateTutorialCars = false;
			TutorialStatus = true;
		}
	}

	void OnEnable()
	{
		EventManager.OnTutorialStep += OnTutorialStep;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
		EventManager.OnShowcaseDisable += OnShowcaseDisable;
		EventManager.OnGearTriggerHit += OnGearTriggerHit;
		EventManager.OnGameStart += OnGameStart;
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
		EventManager.OnLevelComplete += OnLevelComplete;

	}
	void OnDisable()
	{
		EventManager.OnTutorialStep -= OnTutorialStep;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
		EventManager.OnGearTriggerHit -= OnGearTriggerHit;
		EventManager.OnGameStart -= OnGameStart;
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
		EventManager.OnLevelComplete -= OnLevelComplete;

	}

	void OnTutorialStep(int step)
	{
		//	Debug.Log(step);
	}

	void OnLevelComplete()
	{
		currentStep++;
	}

	void OnGearTriggerHit()
	{
		gearCollected++;
	}
	void OnFingerDown()
	{
		//	pointerUpTimer = 0;
	}
	void OnFingerUp()
	{
		//	pointerDownTimer = 0;
	}
	void OnShowcaseEnable()
	{
		Toggle(false);
	}
	void OnShowcaseDisable()
	{
		if (gameStarted == false) return;
		Toggle(GameController.TutorialEnabled);
	}

	void Toggle(bool b)
	{
		canvasGroup.alpha = b ? 1 : 0f;
		canvasGroup.blocksRaycasts = false;
		if (b) GetComponent<Animation>().Play();
	}

	void Start ()
	{

		canvasGroup = GetComponent<CanvasGroup>();

		Toggle(false);

		tutorialText.text = "Keep holding to go";
	}

	void OnGameStart()
	{
		Toggle(GameController.TutorialEnabled);
		TutorialStatus = GameController.TutorialEnabled;
	}
	bool triggered;


	void Update()
	{
		tutorialText.text = "";

		switch (currentStep)
		{
			case 0:
			{
				tutorialText.text = "Hold to go!";

				if (Section.VELOCITY > 15f)
				{
					pointerDownTimer += Time.deltaTime;

					if (pointerDownTimer >= 3f)
					{
						currentStep++;
					}
				}

				stepProgress = pointerDownTimer / 3f;

				break;
			}

			case 1:
			{
				tutorialText.text = "Drag to steer";

				if (Section.VELOCITY > 0)
				{
					dragTimer += Time.deltaTime;

					if (dragTimer >= 3f)
					{
						currentStep++;
					}
				}

				stepProgress = dragTimer / 3f;
				break;
			}

			case 2:
			{
				tutorialText.text = "Collect the gears";

				if (!triggered)
				{
					if (EventManager.OnTutorialStep != null)
						EventManager.OnTutorialStep(currentStep);

					triggered = true;
				}

				if (gearCollected >= 20)
				{
					currentStep++;
				}

				stepProgress = (float)gearCollected / 20f;
				break;
			}

			case 3:
			{
				tutorialText.text = "Let go to stop";

				if (Section.VELOCITY <= 0)
				{
					pointerUpTimer += Time.deltaTime;

					if (pointerUpTimer >= 3)
					{
						currentStep++;
					}
				}

				stepProgress = pointerUpTimer / 3f;
				break;
			}

			case 4:
			{
				tutorialText.text = "Avoid cars at intersection";

				TutorialHandler.ActivateTutorialCars = true;
				TutorialStatus = false;
				stepProgress = 1f;
				break;
			}

			case 5:
			{
				tutorialText.text = "Good Job!";
				break;
			}


		}
		fillImage.fillAmount = stepProgress;
	}

	public int CurrentStep
	{
		get { return currentStep; }
		set {this.currentStep = value; }
	}
}
