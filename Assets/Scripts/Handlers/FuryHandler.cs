using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuryHandler : MonoBehaviour {


	public static FuryHandler Instance;


	public static bool InFury;

	private bool holding;

	private float holdingTimer;

	private bool canRegisterFury;

	private bool furyStarted;

	private CameraController camera;

	private float furyStep;

	private float furyTime;

	private bool levelJustCompleted;

	private int furyLightRan;

	private FuryMeter furyMeter;

	private bool waitForFury;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	void OnEnable ()
	{

		EventManager.OnFingerUp += OnFingerUp;

		EventManager.OnFingerDown += OnFingerDown;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;

		EventManager.OnProgressionColliderExit += OnProgressionColliderExit;

		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnVehicleHit += OnVehicleHit;

		EventManager.OnHitObject += OnHitObject;

		EventManager.OnNearMiss += OnNearMiss;
	}


	void OnDisable ()
	{

		EventManager.OnFingerUp -= OnFingerUp;

		EventManager.OnFingerDown -= OnFingerDown;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;

		EventManager.OnProgressionColliderExit -= OnProgressionColliderExit;

		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnVehicleHit -= OnVehicleHit;

		EventManager.OnHitObject -= OnHitObject;

		EventManager.OnNearMiss -= OnNearMiss;
	}

	void Start()
	{
		camera = FindObjectOfType<CameraController>();

		furyMeter = FindObjectOfType<FuryMeter>();

		InFury = false;


	}

	void OnHitObject()
	{
		if (InFury)
		{
			GameController.Instance.furyBonus++;
		}
	}

	void OnLevelComplete()
	{
		levelJustCompleted = true;
	}

	void OnVehicleHit()
	{
		ResetValues();
		waitForFury = true;
	}

	void Update()
	{
		if (levelJustCompleted) { return; }

		if (holding)
		{
			holdingTimer += Time.deltaTime;

			if (holdingTimer > .35f)
			{
				canRegisterFury = true;
			}
		}
		else
		{
			if (!InFury)
			{
				furyTime -= Time.deltaTime * 2f * furyStep;
			}
		}

		if (InFury)
		{
			furyTime -=  (Time.deltaTime * 3) / GameController.ActiveModel.furyTime.value;
		}

		if (furyTime <= 0)
		{
			StopFury();
			ResetValues();
		}
	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (GameController.TutorialEnabled) { return; }

		StopCoroutine("ICheck");

		StartCoroutine("ICheck", type);
	}

	void OnProgressionColliderExit(ProgressionColliderType type)
	{
		if (GameController.TutorialEnabled) return;

		if (type == ProgressionColliderType.Intersection)
		{
			waitForFury = false;
		}
	}


	IEnumerator ICheck(ProgressionColliderType type)
	{
		yield return new WaitForEndOfFrame();

		if (type == ProgressionColliderType.Intersection)
		{
			if (!InFury)
			{
				Haptic.Instance.VibrateTwice(.15f, HapticIntensity.Light);
			}

			if (canRegisterFury && !waitForFury)
			{
				furyStep++;

				if (!InFury)
				{
					furyTime = furyStep;
				}

				furyStep = Mathf.Clamp(furyStep, 0, 3);
			}

			furyLightRan++;

			if (furyLightRan >= 3 && canRegisterFury && !furyStarted)
			{
				StartFury();
			}

			if (!InFury && FuryStep >= 1)
			{
				furyMeter.TriggerAnimation();
			}
		}
	}

	public void StartFury()
	{

		camera.bloom.enabled = true;

		camera.TriggerPull(-4f, 10f);

		camera.TriggerShake(.75f, 15f);

		InFury = true;

		if (EventManager.OnFuryStatus != null)
		{
			EventManager.OnFuryStatus(1);
		}
		camera.BloomIntensity = camera.BloomIntensity + .7f;

		if (EventManager.OnLogMapStat != null)
		{
			EventManager.OnLogMapStat(MapUnlockConditions.SpecialConditionType.FuryAchieved, 1);
		}

		furyStarted = true;
	}

	void ResetValues()
	{
		furyTime = 0;

		furyStep = 0;

		furyLightRan = 0;
	}

	public void StopFury()
	{

		FuryStep = 0;

		if (InFury)
		{

			//FuryStep = 0;

			furyTime = 0;

			furyLightRan = 0;

			camera.TriggerPull(-2, 20f);

			holdingTimer = 0;

			canRegisterFury = false;

			camera.bloom.enabled = false;

			camera.BloomIntensity = camera.BloomIntensity - .4f;

			InFury = false;

			if (EventManager.OnFuryStatus != null)
			{
				EventManager.OnFuryStatus(0);
			}

			furyStarted = false;
		}
	}

	void OnFingerUp()
	{

		holding = false;

		holdingTimer = 0;

		canRegisterFury = false;
	}
	void OnFingerDown()
	{
		holding = true;

		if (!InFury)
		{
			furyTime = furyStep;
		}
	}

	void OnNearMiss()
	{
		TriggerMiniboost();
	}

	private bool miniBoostActive;
	public void TriggerMiniboost()
	{
		if (miniBoostActive || InFury) return;

		miniBoostActive = true;

		if (EventManager.OnMiniBoost != null)
		{
			EventManager.OnMiniBoost(1);
		}

		StopCoroutine("IStopMiniBoost");
		StartCoroutine("IStopMiniBoost");
	}

	IEnumerator IStopMiniBoost()
	{
		yield return new WaitForSeconds(.5f);

		if (EventManager.OnMiniBoost != null)
		{
			EventManager.OnMiniBoost(0);
		}

		miniBoostActive = false;
	}

	public float FuryStep
	{
		get {return furyStep;}

		set {this.furyStep = value;}
	}

	public float FuryTime
	{
		get {return furyTime;}
	}


}
