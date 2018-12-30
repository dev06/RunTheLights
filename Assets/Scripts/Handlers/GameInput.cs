﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

	private static float MIN_SPEED_DROPOFF = .8F;

	public ParticleSystem zoomParticles;

	public ParticleSystem[] left, right;

	private float vel;

	private float rate;

	private float velocity;

	private float movementMultiplier;

	private float acc;

	private bool pressed;

	private Transform showcaseContainer;

	private ShowcaseModel selectedModel;

	private bool canSteer;

	private BoxCollider modelCollider;

	private Vector2 currentPosition, lastPosition;

	private float rot;

	private float senstivity = 40;

	private float durability; //used for hud

	private float speedDropOff; //0-1 value that measures the effiency of the car after damage delt

	private float miniBoostSpeed, miniBoostSpeedVel;

	void OnEnable()
	{
		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;
		EventManager.OnGameStart += OnGameStart;
		EventManager.OnLevelComplete += OnLevelComplete;
		EventManager.OnFuryStatus += OnFuryStatus;
		EventManager.OnMiniBoost += OnMiniBoost;

	}

	void OnDisable()
	{
		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;
		EventManager.OnGameStart -= OnGameStart;
		EventManager.OnLevelComplete -= OnLevelComplete;
		EventManager.OnFuryStatus -= OnFuryStatus;
		EventManager.OnMiniBoost -= OnMiniBoost;

	}

	void Start()
	{
		showcaseContainer = FindObjectOfType<ShowcaseHandler>().transform;
		ToggleModel(GameController.SELECTED_MODEL_INDEX);
		canSteer = true;
	}

	void LateUpdate ()
	{
		if (GameController.GameOver || GraphicRaycasterRaycasterExample.HITTING_UI || GameController.INSHOWCASE)
		{
			Section.VELOCITY = 0f;
			velocity = 0f;
			return;
		}

		if (Section.VELOCITY <= 0)
		{
			if (zoomParticles.isPlaying)
			{
				zoomParticles.Stop();
			}
		}
		else
		{
			if (FuryHandler.InFury && !zoomParticles.isPlaying)
			{
				zoomParticles.Play();
			}
		}


		MovePlayer();
	}

	void OnMiniBoost(int i)
	{
		if (FuryHandler.InFury) return;

		if (i == 1)
		{
			miniBoostSpeed = 3f;
		}
	}

	void OnGameStart()
	{
		canSteer = true;
	}

	void OnFuryStatus(int i)
	{
		if (i == 0)
		{
			zoomParticles.Stop();
		}
		else
		{
			zoomParticles.Play();
		}
	}

	private void OnLevelComplete()
	{
		canSteer = false;

		zoomParticles.Stop();

		modelCollider.enabled = false;

		StopCoroutine("IEndLevelAnimation");

		StartCoroutine("IEndLevelAnimation");

		bool damageNotTaken = VehicleDurability == GameController.ActiveModel.durability.value;

		if (damageNotTaken)
		{
			if (EventManager.OnLogMapStat != null)
			{
				EventManager.OnLogMapStat(MapUnlockConditions.SpecialConditionType.ZeroDamage, 1);
			}
		}
	}

	IEnumerator IEndLevelAnimation()
	{
		float timer = 0;

		while (timer < 4f)
		{
			timer += Time.deltaTime;

			velocity = selectedModel.Speed;

			Section.VELOCITY = velocity;

			yield return null;
		}

		Section.VELOCITY = 0;
	}

	public void MovePlayer()
	{
		if (canSteer == false) { return; }

		speedDropOff = VehicleDurability / GameController.ActiveModel.durability.value;

		speedDropOff = Mathf.Clamp(speedDropOff, MIN_SPEED_DROPOFF, 1f);

		if (Input.GetMouseButtonDown(0))
		{
			pressed = true;

			if (EventManager.OnFingerDown != null)
			{
				EventManager.OnFingerDown();
			}
		}

		if (Input.GetMouseButtonUp(0))
		{

			if (EventManager.OnFingerDown != null)
			{
				EventManager.OnFingerUp();
			}

		}




		if (!pressed && !FuryHandler.InFury) { return; }

		if (FuryHandler.InFury)
		{
			velocity = speedDropOff * selectedModel.Speed * 1.5f;
			Control();
		}
		else
		{
			if (Input.GetMouseButton(0))
			{

				velocity += Time.deltaTime * selectedModel.acceleration;



				Control();
			}
			else
			{
				velocity -= Time.deltaTime * selectedModel.deceleration;
			}

			miniBoostSpeed = Mathf.SmoothDamp(miniBoostSpeed, 1f, ref miniBoostSpeedVel, Time.deltaTime * 10f);

			velocity = Mathf.Clamp(velocity, 0, speedDropOff * selectedModel.Speed * (FuryHandler.InFury ? 1.5f : 1f) * miniBoostSpeed);
		}

		//Vector3 addition = new Vector3(0, (velocity > 0 ? 1f : 0) * (Mathf.PingPong(Time.realtimeSinceStartup, .05f) - .025f), 0);
		//transform.position += addition;


		Section.VELOCITY = velocity;
	}


	void Control()
	{
		if (GameController.TutorialEnabled)
		{
			if (TutorialHandler.Instance.CurrentStep < 1)
			{
				return;
			}
		}

		if (!Input.GetMouseButton(0)) return;

		if (!FuryHandler.InFury && !pressed) { return; }


		currentPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

		if (Input.GetMouseButtonDown(0))
		{
			lastPosition = currentPosition;
		}

		float diff = (currentPosition.x - lastPosition.x) * 4f;



		rot += diff;


		float m = .35f;

		if (diff < -m)
		{
			for (int i = 0; i < left.Length; i++)
			{
				left[i].Play();
			}

		}
		if (diff > m)
		{
			for (int i = 0; i < right.Length; i++)
			{
				right[i].Play();
			}
		}

		rot = Mathf.Clamp(rot, -1f, 1f);

		transform.position = Vector3.Lerp(transform.position, new Vector3(rot, transform.position.y, transform.position.z), Time.deltaTime * 10f);


		lastPosition = currentPosition;
	}

	public void ToggleModel(int index)
	{
		for (int i = 0; i < transform.GetChild(0).transform.childCount; i++)
		{
			transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(false);
		}



		ShowcaseModel model = showcaseContainer.GetChild(index).GetComponent<ShowcaseModel>();

		if (!model.isUnlocked())
		{
			index = 0;

			model = showcaseContainer.GetChild(index).GetComponent<ShowcaseModel>();

			GameController.SELECTED_MODEL_INDEX = index;
		}

		selectedModel = model;

		transform.GetChild(0).transform.GetChild(index).gameObject.SetActive(true);

		modelCollider = transform.GetChild(0).transform.GetChild(index).GetComponent<BoxCollider>();

		GameController.ActiveModel = model;


		CameraController.Instance.SetCameraHeightOffset(model.cameraPositionOffset);



	}

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		ToggleModel(GameController.SELECTED_MODEL_INDEX);
	}


	public float VehicleDurability
	{
		get { return durability;}
		set { this.durability = value; }
	}
}
