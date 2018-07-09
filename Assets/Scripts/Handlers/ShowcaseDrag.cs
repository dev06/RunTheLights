using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowcaseDrag : MonoBehaviour {

	private Vector3 currentPosition;
	private Vector3 lastPosition;
	private ShowModel selectedShowModel;
	private GameObject selectedModel;
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
			FindObjectOfType<GameInput>().ToggleModel(selectingIndex);
			GameController.SELECTED_MODEL_INDEX = selectingIndex;
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

				if (selectedShowModel != null)
				{
					selectedShowModel.ResetTransform();
				}

				rot = Mathf.Round(rot);
				Vector3 pos = transform.GetChild((int)rot).position;
				CameraController.Instance.SetTargetPosition(pos + new Vector3(7, 1, 0));
				selectedShowModel = transform.GetChild((int)rot).GetComponent<ShowModel>();
				selectingIndex = (int)rot;
				selectedShowModel.Select();
				Haptic.Vibrate(HapticIntensity.Medium);
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

		float diff = (currentPosition.x - lastPosition.x) * 10f;

		rot -= diff;

		rot = Mathf.Clamp(rot, 0, transform.childCount - 1);

		lastPosition = currentPosition;


	}

}
