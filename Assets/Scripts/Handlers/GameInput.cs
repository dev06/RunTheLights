﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {


	private float vel;

	private float rate;

	private float velocity;

	private float movementMultiplier;

	private float acc;

	private bool pressed;

	private Transform showcaseContainer;

	private ShowcaseModel selectedModel;

	private bool canSteer;

	void OnEnable()
	{
		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;
		EventManager.OnGameStart += OnGameStart;
		EventManager.OnLevelComplete += OnLevelComplete;
	}
	void OnDisable()
	{
		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;
		EventManager.OnGameStart -= OnGameStart;
		EventManager.OnLevelComplete -= OnLevelComplete;
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

		MovePlayer();
	}

	void OnGameStart()
	{
		canSteer = true;
	}

	private void OnLevelComplete()
	{
		canSteer = false;

		StopCoroutine("IEndLevelAnimation");

		StartCoroutine("IEndLevelAnimation");
	}

	IEnumerator IEndLevelAnimation()
	{
		float timer = 0;

		while (timer < 4f)
		{
			timer += Time.deltaTime;

			velocity = selectedModel.speed;

			Section.VELOCITY = velocity;

			yield return null;
		}

		Section.VELOCITY = 0;
	}

	public void MovePlayer()
	{
		if (canSteer == false) { return; }

		if (Input.GetMouseButtonDown(0))
		{
			pressed = true;

			if (EventManager.OnFingerDown != null)
			{
				EventManager.OnFingerDown();
			}
		}
		else if (Input.GetMouseButtonUp(0))
		{

			if (EventManager.OnFingerDown != null)
			{
				EventManager.OnFingerUp();
			}

		}

		if (!pressed) { return; }

		if (Input.GetMouseButton(0))
		{

			velocity += Time.deltaTime * selectedModel.acceleration;

			Control();
		}
		else
		{
			velocity -= Time.deltaTime * selectedModel.deceleration;
		}

		velocity = Mathf.Clamp(velocity, 0, selectedModel.speed);

		Section.VELOCITY = velocity;


		GameController.GAME_DISTANCE += velocity * .02f;
		GameController.GAME_DISTANCE = Mathf.Round(GameController.GAME_DISTANCE * 10f) / 10f;
		GameController.GAME_DISTANCE = Mathf.Clamp(GameController.GAME_DISTANCE, 0, GameController.GAME_DISTANCE);
	}


	private Vector2 currentPosition, lastPosition;

	private float rot;

	private float senstivity = 40;
	void Control()
	{

		if (!pressed) { return; }


		currentPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

		if (Input.GetMouseButtonDown(0))
		{
			lastPosition = currentPosition;
		}

		float diff = (currentPosition.x - lastPosition.x) * 4f;

		rot += diff;

		rot = Mathf.Clamp(rot, -1f, 1f);

		transform.position = new Vector3(rot, transform.position.y, transform.position.z);


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

		GameController.ActiveModel = model;

		GameController.MOVEMENT_MULTIPLIER = model.movementMultiplier;

	}

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		ToggleModel(GameController.SELECTED_MODEL_INDEX);
	}


}
