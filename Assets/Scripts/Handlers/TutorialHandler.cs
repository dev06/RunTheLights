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

	private int objectsHit;

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
		EventManager.OnHitObject += OnHitObject;

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
		EventManager.OnHitObject -= OnHitObject;

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

	void OnHitObject()
	{
		objectsHit++;
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


		Toggle(GameController.TutorialEnabled);
		TutorialStatus = GameController.TutorialEnabled;

		tutorialText.text = "Keep holding to go";
	}

	void OnGameStart()
	{

	}
	bool triggered;


	public const  int STEP_GO = 0;
	public const  int STEP_STEER = 1;
	public const  int STEP_STOP = 2;
	public const  int STEP_CLEAR = 3;
	public const  int STEP_GEAR = 4;
	public const  int STEP_AVOID = 5;
	public const  int STEP_FINISH = 6;


	void Update()
	{
		tutorialText.text = "";

		switch (currentStep)
		{
			case STEP_GO:
			{
				tutorialText.text = "Hold to go!";

				if (Section.VELOCITY > 10f)
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

			case STEP_STEER:
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

			case STEP_STOP:
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

			case STEP_CLEAR:
			{
				tutorialText.text = "Clear the road";

				if (objectsHit >= 8)
				{
					currentStep++;
				}

				stepProgress = (float)objectsHit / 8f;

				break;
			}


			case STEP_GEAR:
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


			case STEP_AVOID:
			{
				tutorialText.text = "Avoid cars at intersection";
				TutorialHandler.ActivateTutorialCars = true;
				TutorialStatus = false;
				stepProgress = 1f;
				break;
			}

			case STEP_FINISH:
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

	IEnumerator IStartCarStreams()
	{
		yield return new WaitForSeconds(1);

	}
}
