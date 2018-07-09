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
	}
	void OnDisable()
	{
		EventManager.OnHitObject -= OnHitObject;
		EventManager.OnGameOver -= OnGameOver;
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
		EventManager.OnShowcaseDisable -= OnShowcaseDisable;
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

	// Update is called once per frame
	void Update ()
	{
		//if (GameController.GameOver) return;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameController.INSHOWCASE = !GameController.INSHOWCASE;
			UpdateTransform();
		}

		if (!GameController.INSHOWCASE)
		{
			shakeIntensity = Mathf.SmoothDamp(shakeIntensity, 0, ref shakeVel, Time.deltaTime * shakeDuration);

			transform.localPosition = defaultPositon + Shake();
		}
		else
		{
			transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * 10f);
		}
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
