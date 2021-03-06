﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseHandler : MonoBehaviour {

	public Color showcaseBackgroundColor;

	public Transform showcaseTransform;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private ShowcaseModel selectedShowcaseModel;

	private float rot;

	private bool selected;

	private float distanceOffset = 7f;

	private int selectingIndex;

	//camera offset vehicle.
	private Vector3 offset = new Vector3(15, 5, 0);

	private Vector3 snapPos;

	private int lastSelectedIndex;

	private CameraController cameraController;
	bool dragging = false;
	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
		EventManager.OnGameStart += OnGameStart;
		EventManager.OnShowcaseEnable += OnShowcaseEnable;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnGameStart -= OnGameStart;
		EventManager.OnShowcaseEnable -= OnShowcaseEnable;
	}

	void OnGameStart()
	{
		transform.gameObject.SetActive(false);
	}

	void OnShowcaseEnable()
	{
		cameraController.transform.position = snapPos + offset + new Vector3(0, 0, -50);

		cameraController.SetTransform(snapPos + offset, showcaseTransform.rotation);

		cameraController.SetBackgroundColor(showcaseBackgroundColor);
	}


	void OnButtonClick(ButtonID id)
	{
		if (id == ButtonID.SelectModel)
		{
			GameController.SELECTED_MODEL_INDEX = selectingIndex;

			PlayerPrefs.SetInt("SELECTED_MODEL_INDEX", GameController.SELECTED_MODEL_INDEX);


			if (EventManager.OnShowcaseModelSelected != null)
			{
				EventManager.OnShowcaseModelSelected(selectedShowcaseModel);
			}
		}
	}


	public void Init()
	{
		cameraController = CameraController.Instance;

		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).GetComponent<ShowcaseModel>().Init();
			transform.GetChild(i).localPosition = new Vector3(transform.GetChild(i).localPosition.x, 0, i * distanceOffset);
		}
	}



	void Update()
	{
		if (!GameController.INSHOWCASE) return;

		if (Input.GetMouseButton(0))
		{

			Control();

			float x = (snapPos + offset).x;

			float y = (snapPos + offset).y;

			cameraController.SetTargetPosition(new Vector3(x, y, rot * distanceOffset));

			if (Mathf.Abs(rot) > .1f)
			{
				selected = false;
			}
		}
		else
		{
			if (!selected)
			{

				if (selectedShowcaseModel != null)
				{
					selectedShowcaseModel.ResetTransform();
				}


				rot = Mathf.Round(rot);

				snapPos = transform.GetChild((int)rot).position;

				cameraController.SetTransform(snapPos + offset, showcaseTransform.rotation);

				selectedShowcaseModel = transform.GetChild((int)rot).GetComponent<ShowcaseModel>();

				selectingIndex = (int)rot;

				if (lastSelectedIndex != selectingIndex)
				{
					Haptic.Vibrate(HapticIntensity.Light);
				}

				lastSelectedIndex = selectingIndex;

				selectedShowcaseModel.Select();

				if (EventManager.OnShowcaseModelHover != null)
				{
					EventManager.OnShowcaseModelHover(selectedShowcaseModel);
				}
				selected = true;
			}


		}
	}

	void Control()
	{

		currentPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

		if (Input.GetMouseButtonDown(0))
		{
			lastPosition = currentPosition;
		}

		float diff = (currentPosition.x - lastPosition.x) * 3f;

		rot -= diff;

		rot = Mathf.Clamp(rot, 0, transform.childCount - 1);

		lastPosition = currentPosition;
	}
}
