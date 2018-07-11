using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseHandler : MonoBehaviour {

	public Transform showcaseTransform;
	private Vector3 currentPosition;
	private Vector3 lastPosition;
	private ShowcaseModel selectedShowcaseModel;
	private float rot;
	private bool selected;
	private float distanceOffset = 4f;
	private int selectingIndex;
	private Vector3 offset = new Vector3(7, 3, 0);
	private Vector3 snapPos;
	private int lastSelectedIndex;
	private CameraController cameraController;

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
		cameraController.SetTransform(snapPos + offset, showcaseTransform.rotation);
	}


	void OnButtonClick(ButtonID id)
	{
		if (id == ButtonID.SelectModel)
		{
			GameController.SELECTED_MODEL_INDEX = selectingIndex;

			if (EventManager.OnShowcaseModelSelected != null)
			{
				EventManager.OnShowcaseModelSelected(selectedShowcaseModel);
			}


		}
	}



	void Start()
	{
		cameraController = CameraController.Instance;

		for (int i = 1; i < transform.childCount; i++)
		{
			transform.GetChild(i).localPosition = new Vector3(0, 0, i * distanceOffset);
		}
	}


	bool dragging = false;
	void Update()
	{
		if (!GameController.INSHOWCASE) return;

		if (Input.GetMouseButton(0))
		{

			Control();

			cameraController.SetTargetPosition(new Vector3(cameraController.transform.position.x, cameraController.transform.position.y, rot * distanceOffset));

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
				//CameraController.Instance.SetTargetPosition(pos + offset);
				cameraController.SetTransform(snapPos + offset, showcaseTransform.rotation);
				selectedShowcaseModel = transform.GetChild((int)rot).GetComponent<ShowcaseModel>();
				selectingIndex = (int)rot;

				if (lastSelectedIndex != selectingIndex)
				{
					Haptic.Vibrate(HapticIntensity.Medium);
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
