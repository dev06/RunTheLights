﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuryHandler : MonoBehaviour {


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

	void OnEnable ()
	{

		EventManager.OnFingerUp += OnFingerUp;

		EventManager.OnFingerDown += OnFingerDown;

		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;

		EventManager.OnLevelComplete += OnLevelComplete;
	}


	void OnDisable ()
	{

		EventManager.OnFingerUp -= OnFingerUp;

		EventManager.OnFingerDown -= OnFingerDown;

		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;

		EventManager.OnLevelComplete -= OnLevelComplete;
	}

	void Start()
	{
		camera = FindObjectOfType<CameraController>();

		furyMeter = FindObjectOfType<FuryMeter>();

		InFury = false;
	}

	void OnLevelComplete()
	{
		levelJustCompleted = true;
	}

	void Update()
	{
		if (levelJustCompleted) { return; }

		if (holding)
		{
			holdingTimer += Time.deltaTime;

			if (holdingTimer > .5f)
			{
				canRegisterFury = true;
			}
		}
		else
		{
			if (!InFury)
			{
				furyTime -= Time.deltaTime;
			}
		}

		if (InFury)
		{
			furyTime -= Time.deltaTime * .5f;
		}

		if (furyTime <= 0)
		{
			StopFury();
		}
	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		StopCoroutine("ICheck");

		StartCoroutine("ICheck", type);
	}

	IEnumerator ICheck(ProgressionColliderType type)
	{
		yield return new WaitForEndOfFrame();


		if (type == ProgressionColliderType.Intersection)
		{

			if (canRegisterFury)
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

			if (!InFury)
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
		camera.BloomIntensity = camera.BloomIntensity + .4f;

		furyStarted = true;
	}

	public void StopFury()
	{


		if (InFury)
		{

			FuryStep = 0;

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


	}
	void OnFingerDown()
	{
		holding = true;

		if (!InFury)
		{
			furyTime = furyStep;
		}
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