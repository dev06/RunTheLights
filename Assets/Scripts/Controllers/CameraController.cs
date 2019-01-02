using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;
public class CameraController : MonoBehaviour {


	public static CameraController Instance;

	public Light directionalLight;
	public Transform sectionContainer;
	public Transform showcaseTransform;
	public Transform defaultTransform;

	private float shakeIntensity;
	private float shakeDuration;
	private float shakeVel;
	private Vector3 defaultPositon;
	private Vector3 heightOffset;

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
	private float continuousShakeIntensity = .05f;
	private float startIntensity, startIntensityVel;

	private Vector3 targetPosition;


	private bool inStopZone;
	private bool isCameraDetached;
	private bool pressed;

	public BloomOptimized bloom;
	private ScreenOverlay screenOverlay;
	private GameInput player;


	private Animation animation;
	private Color defaultSkyColor;


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
		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;

		EventManager.OnFuryStatus += OnFuryStatus;
		EventManager.OnMiniBoost += OnMiniBoost;

		EventManager.OnMapSelected += OnMapSelected;
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
		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;
		EventManager.OnFuryStatus -= OnFuryStatus;
		EventManager.OnMiniBoost -= OnMiniBoost;

		EventManager.OnMapSelected -= OnMapSelected;
	}

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		SetCameraHeightOffset(model.cameraPositionOffset);
	}


	void OnFingerDown()
	{
		pressed = true;
		if (FuryHandler.InFury) return;
		TriggerPull(-2f, 10f);
		startIntensity = .1f;
	}

	void OnFuryStatus(int i)
	{
		if ( i == 1)
		{
			float multiplier = (i == 1) ? 2f : 1f;
			TriggerPull(-2f * multiplier, 20f * multiplier);
			startIntensity = .1f;
		}

		if (i == 0)
		{
			if (!pressed)
			{
				TriggerPull(0, 15f);
			}
		}
	}

	void OnMiniBoost(int i)
	{
		if (FuryHandler.InFury) return;
		if (i == 1)
		{
			TriggerPull(-5f, 5f); // smaller = faster
			TriggerShake(.5f, 15f);
		}
		else
		{
			TriggerPull((pressed ? -2 : 0), 20f);

		}
	}


	void OnFingerUp()
	{
		pressed = false;
		if (FuryHandler.InFury) return;
		TriggerPull(0, 15f);
	}

	void OnLevelComplete()
	{
		DetachCamera();
	}


	void OnShowcaseDisable()
	{
		SetTransform(defaultTransform.position, defaultTransform.rotation);
		sectionContainer.gameObject.SetActive(true);
		SetBackgroundColor(defaultSkyColor);
		directionalLight.color = defaultSkyColor;
	}

	void OnShowcaseEnable()
	{
		sectionContainer.gameObject.SetActive(false);
		directionalLight.color = Color.white;
	}

	void OnMapSelected(Map m)
	{
		UpdateSkyColor();
	}

	void OnHitObject()
	{
		TriggerShake();
	}

	void OnGameOver()
	{
		TriggerShake(1f, 10f);
	}

	public void UpdateSkyColor()
	{
		defaultSkyColor = MapSelectUI.SelectedMap.skyColor;
		directionalLight.color = defaultSkyColor;
		RenderSettings.fogColor = defaultSkyColor;
		SetBackgroundColor(defaultSkyColor);

	}

	void Start ()
	{
		//UpdateTransform();
		bloom = GetComponent<BloomOptimized>();
		screenOverlay = GetComponent<ScreenOverlay>();
		parent = transform.parent;
		defaultPositon = transform.localPosition;
		targetPosition = transform.position;
		defaultFOV = Camera.main.fieldOfView;
		stopFOV = defaultFOV + 35f;
		targetFOV = defaultFOV;

		player = FindObjectOfType<GameInput>();
		animation = GetComponent<Animation>();

	}

	float s = 0, vv;
	Vector3 lerpVector;

	void Update ()
	{

		screenOverlay.enabled = FuryHandler.InFury;
		if (!GameController.INSHOWCASE)
		{
			if (!isCameraDetached)
			{

				shakeIntensity = Mathf.SmoothDamp(shakeIntensity, 0, ref shakeVel, Time.deltaTime * shakeDuration);

				pullAmount = Mathf.SmoothDamp(pullAmount, targetPull, ref pullVel, Time.deltaTime * pullDamp);

				startIntensity = Mathf.SmoothDamp(startIntensity, 0, ref startIntensityVel, Time.deltaTime * 20f);

				continuousShakeIntensity = (FuryHandler.InFury) ? .07f : 0f;

				Vector3 target =  player.transform.position +  heightOffset + defaultPositon + Shake() + ContinuousShake() + new Vector3(0, 0, pullAmount) + (Vector3)(Random.insideUnitCircle * startIntensity);

				lerpVector = Vector3.Lerp(lerpVector, target, Time.deltaTime * 20f);

				lerpVector.y = target.y;

				lerpVector.z = target.z;

				transform.position = lerpVector;

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

	public void SetCameraHeightOffset(Vector3 cameraPositionOffset)
	{
		heightOffset =  cameraPositionOffset;
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

	public void SetBackgroundColor(Color color)
	{
		Camera.main.backgroundColor = color;
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

	public void TriggerAnimation()
	{
		animation.Play();
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
