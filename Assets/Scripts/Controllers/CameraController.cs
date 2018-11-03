﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
public class CameraController : MonoBehaviour {


	public static CameraController Instance;

	public Transform sectionContainer;
	public Transform showcaseTransform;
	public Transform defaultTransform;

	private float shakeIntensity;
	private float shakeDuration;
	private float shakeVel;
	private Vector3 defaultPositon;

	public bool ToggleShowcaseCamera;

	private Transform parent;
	private float targetPull;
	private float pullAmount;
	private float pullVel;
	private float v;
	private float pullDamp;

	private float defaultFOV;
	private float stopFOV;
	private float targetFOV;
	private float fovVel;
	private float fovThreshold;

	private Vector3 targetPosition;

	private float startIntensity, startIntensityVel;

	private bool inStopZone;
	private bool isCameraDetached;

	public BloomOptimized bloom;

	private float continuousShakeIntensity = .05f;


	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	void OnValidate()
	{
		//	transform.localPosition = ToggleShowcaseCamera ? showcaseTransform.position : transform.localPosition = defaultTransform.position;;
		//	transform.localRotation = ToggleShowcaseCamera ? showcaseTransform.rotation :	transform.localRotation = defaultTransform.rotation;;
	}

	void OnEnable()
	{
		EventManager.OnHitObject += OnHitObject;
		EventManager.OnGameOver += OnGameOver;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
		EventManager.OnShowcaseDisable += OnShowcaseDisable;
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
		EventManager.OnLevelComplete += OnLevelComplete;
	}
	void OnDisable()
	{
		EventManager.OnHitObject -= OnHitObject;
		EventManager.OnGameOver -= OnGameOver;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
		EventManager.OnLevelComplete -= OnLevelComplete;
	}


	void OnFingerDown()
	{
		float multiplier = FuryHandler.InFury ? 2f : 1f;
		TriggerPull(-2f * multiplier, 20f * multiplier);
		startIntensity = .1f;
	}

	void OnFingerUp()
	{
		TriggerPull(0, 20f);
	}

	void OnLevelComplete()
	{
		DetachCamera();
	}


	void OnShowcaseDisable()
	{
		SetTransform(defaultTransform.position, defaultTransform.rotation);
		sectionContainer.gameObject.SetActive(true);
	}

	void OnShowcaseEnable()
	{
		sectionContainer.gameObject.SetActive(false);
	}

	void OnHitObject()
	{
		TriggerShake();
	}

	void OnGameOver()
	{
		TriggerShake(1f, 10f);
	}

	void Start ()
	{
		//UpdateTransform();
		bloom = GetComponent<BloomOptimized>();
		parent = transform.parent;
		defaultPositon = transform.localPosition;
		targetPosition = transform.position;

		defaultFOV = Camera.main.fieldOfView;
		stopFOV = defaultFOV + 35f;
		targetFOV = defaultFOV;
	}

	float s = 0, vv;
	void Update ()
	{

		if (!GameController.INSHOWCASE)
		{
			if (!isCameraDetached)
			{

				shakeIntensity = Mathf.SmoothDamp(shakeIntensity, 0, ref shakeVel, Time.deltaTime * shakeDuration);

				pullAmount = Mathf.SmoothDamp(pullAmount, targetPull, ref pullVel, Time.deltaTime * pullDamp);

				startIntensity = Mathf.SmoothDamp(startIntensity, 0, ref startIntensityVel, Time.deltaTime * 20f);

				continuousShakeIntensity = (FuryHandler.InFury && Section.VELOCITY >= GameController.ActiveModel.speed) ? .05f : 0f;

				transform.localPosition = defaultPositon + Shake() + ContinuousShake() + new Vector3(0, 0, pullAmount) + (Vector3)(Random.insideUnitCircle * startIntensity);
			}
			else
			{
				s = Mathf.SmoothDamp(s, Section.VELOCITY, ref vv, Time.deltaTime * 25f);
				transform.Translate(-Vector3.forward * Time.deltaTime * s, Space.World);
			}
		}
		else
		{
			transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10f);
			fovThreshold = 0;
			targetFOV = defaultFOV;
		}

		if (isCameraDetached) { return; }

		if (inStopZone)
		{
			fovThreshold += Time.deltaTime;

			if (fovThreshold > .3f)
			{
				targetFOV = stopFOV;
			}
		}


		if (Section.VELOCITY > 0 || !InStopZone)
		{
			fovThreshold = 0;
			targetFOV = defaultFOV;
		}

		if (GameController.GameOver)
		{
			targetFOV = defaultFOV;
		}


		Camera.main.fieldOfView = Mathf.SmoothDamp(Camera.main.fieldOfView, targetFOV, ref fovVel, Time.deltaTime * 10f);


	}

	public void TriggerPull(float pull, float damp)
	{
		pullDamp = damp;
		targetPull = pull;
	}


	public void TriggerShake(float intensity = .15f, float duration = 5f)
	{
		shakeIntensity = intensity;
		shakeDuration = duration;
	}

	Vector3 ContinuousShake()
	{
		return Random.insideUnitCircle * continuousShakeIntensity;
	}

	Vector3 Shake()
	{
		return Random.insideUnitCircle * shakeIntensity;
	}


	public void SetTargetPosition(Vector3 position) {
		targetPosition = position;
	}

	public void SetTransform(Vector3 position, Quaternion rotation)
	{
		targetPosition = position;
		transform.rotation = rotation;
	}

	public bool InStopZone
	{
		get {
			return inStopZone;
		}

		set {
			this.inStopZone = value;
		}
	}

	public void AttachCameraToParent()
	{
		if (parent != null)
		{
			transform.SetParent(parent);
			isCameraDetached = false;
		}
		else
		{
			Debug.Log("Cannot attach camera to parent. Parent is null.");
		}
	}

	public void DetachCamera()
	{
		transform.SetParent(null);
		isCameraDetached = true;
	}

	public float BloomIntensity
	{
		get {
			return bloom.intensity;
		}

		set {
			this.bloom.intensity = value;
		}
	}
}
