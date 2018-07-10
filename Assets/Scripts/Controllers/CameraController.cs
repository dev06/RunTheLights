using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	public static CameraController Instance;

	public Transform showcaseTransform;
	public Transform defaultTransform;

	private float shakeIntensity;
	private float shakeDuration;
	private float shakeVel;
	private Vector3 defaultPositon;

	float targetPull;
	float pullAmount;
	float pullVel;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}


	void OnEnable()
	{
		EventManager.OnHitObject += OnHitObject;
		EventManager.OnGameOver += OnGameOver;
		EventManager.OnButtonClick += OnButtonClick;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
		EventManager.OnShowcaseDisable += OnShowcaseDisable;
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
	}
	void OnDisable()
	{
		EventManager.OnHitObject -= OnHitObject;
		EventManager.OnGameOver -= OnGameOver;
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
	}

	void OnFingerUp()
	{
		TriggerPull(0, 20f);
	}

	void OnFingerDown()
	{
		TriggerPull(-2f, 20f);
	}

	void OnShowcaseDisable()
	{
		GameController.INSHOWCASE = false;
		UpdateTransform();
	}

	void OnShowcaseEnable()
	{
		UpdateTransform();
	}

	void OnHitObject()
	{
		TriggerShake();
	}

	void OnButtonClick(ButtonID id)
	{
		if (id == ButtonID.Showcase)
		{
			GameController.INSHOWCASE = true;
			UpdateTransform();
		}
	}

	void OnGameOver()
	{
		TriggerShake(1f, 10f);
	}

	void Start ()
	{
		UpdateTransform();
		defaultPositon = transform.localPosition;
		targetPosition = transform.localPosition;
	}

	float v;
	float pullDamp;
	// Update is called once per frame
	void Update ()
	{
		//if (GameController.GameOver) return;



		//targetPull = Mathf.SmoothDamp(targetPull, 0f, ref v, Time.deltaTime * 10f);


		if (!GameController.INSHOWCASE)
		{
			shakeIntensity = Mathf.SmoothDamp(shakeIntensity, 0, ref shakeVel, Time.deltaTime * shakeDuration);

			pullAmount = Mathf.SmoothDamp(pullAmount, targetPull, ref pullVel, Time.deltaTime * pullDamp);

			transform.localPosition = defaultPositon + Shake() + new Vector3(0, 0, pullAmount);
		}
		else
		{
			transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * 10f);
		}
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

	private void UpdateTransform()
	{

		if (GameController.INSHOWCASE)
		{
			transform.localPosition = showcaseTransform.position;
			transform.localRotation = showcaseTransform.rotation;
		}
		else
		{
			transform.localPosition = defaultTransform.position;
			transform.localRotation = defaultTransform.rotation;
		}
	}

	Vector3 targetPosition;
	public void SetTargetPosition(Vector3 position)
	{
		targetPosition = position;
	}
}
