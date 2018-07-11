using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

	Vector3 targetPosition;
	private float startIntensity, startIntensityVel;

	private bool inStopZone;


	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	void OnValidate()
	{
		transform.localPosition = ToggleShowcaseCamera ? showcaseTransform.position : transform.localPosition = defaultTransform.position;;
		transform.localRotation = ToggleShowcaseCamera ? showcaseTransform.rotation :	transform.localRotation = defaultTransform.rotation;;
	}

	void OnEnable()
	{
		EventManager.OnHitObject += OnHitObject;
		EventManager.OnGameOver += OnGameOver;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
		EventManager.OnShowcaseDisable += OnShowcaseDisable;
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
	}
	void OnDisable()
	{
		EventManager.OnHitObject -= OnHitObject;
		EventManager.OnGameOver -= OnGameOver;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
	}


	void OnFingerDown()
	{
		TriggerPull(-2f, 20f);
		startIntensity = .1f;
	}

	void OnFingerUp()
	{
		TriggerPull(0, 20f);
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
		defaultPositon = transform.localPosition;
		targetPosition = transform.localPosition;

		defaultFOV = Camera.main.fieldOfView;
		stopFOV = defaultFOV + 35f;
		targetFOV = defaultFOV;
	}

	void Update ()
	{


		if (!GameController.INSHOWCASE)
		{
			shakeIntensity = Mathf.SmoothDamp(shakeIntensity, 0, ref shakeVel, Time.deltaTime * shakeDuration);

			pullAmount = Mathf.SmoothDamp(pullAmount, targetPull, ref pullVel, Time.deltaTime * pullDamp);

			startIntensity = Mathf.SmoothDamp(startIntensity, 0, ref startIntensityVel, Time.deltaTime * 20f);

			transform.localPosition = defaultPositon + Shake() + new Vector3(0, 0, pullAmount) + (Vector3)(Random.insideUnitCircle * startIntensity);

		}
		else
		{
			transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10f);
			fovThreshold = 0;
			targetFOV = defaultFOV;
		}

		if (inStopZone)
		{
			fovThreshold += Time.deltaTime;
			if (fovThreshold > .4f)
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

	Vector3 Shake()
	{
		return Random.insideUnitCircle * shakeIntensity;
	}


	public void SetTargetPosition(Vector3 position)
	{
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
}
