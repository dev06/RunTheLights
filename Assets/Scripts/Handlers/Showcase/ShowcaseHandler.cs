using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseHandler : MonoBehaviour {

	private Vector3 currentPosition;
	private Vector3 lastPosition;
	private ShowcaseModel selectedShowcaseModel;
	private float rot;
	private bool selected;
	private float distanceOffset = 4f;
	private int selectingIndex;

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
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
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild(i).localPosition = new Vector3(0, 0, i * distanceOffset);
		}
	}


	void Update()
	{
		if (!GameController.INSHOWCASE) return;

		if (Input.GetMouseButton(0))
		{
			Control();

			CameraController.Instance.SetTargetPosition(new Vector3(CameraController.Instance.transform.localPosition.x, CameraController.Instance.transform.localPosition.y, rot * distanceOffset));

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
				Vector3 pos = transform.GetChild((int)rot).position;
				CameraController.Instance.SetTargetPosition(pos + new Vector3(7, 1, 0));
				selectedShowcaseModel = transform.GetChild((int)rot).GetComponent<ShowcaseModel>();
				selectingIndex = (int)rot;
				selectedShowcaseModel.Select();
				Haptic.Vibrate(HapticIntensity.Medium);

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
