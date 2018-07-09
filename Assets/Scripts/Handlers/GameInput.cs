using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {



	private float targetVelocity;

	private float vel;

	private float rate;

	private float velocity;

	private float acc;

	private bool pressed;

	void Start()
	{
		ToggleModel(GameController.SELECTED_MODEL_INDEX);
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

	public void MovePlayer()
	{
		if (Input.GetMouseButtonDown(0))
		{
			pressed = true;
		}
		if (Input.GetMouseButton(0))
		{
			velocity += Time.deltaTime * 20f;
			targetVelocity = 200;

			Control();
			rate = 100f;
		}
		else
		{
			targetVelocity = 0;
			velocity -= Time.deltaTime * 30f;
			rate = 80;
		}

		velocity = Mathf.Clamp(velocity, 0, GameController.MAX_VELOCITY);

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

		if (!pressed) return;

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

		transform.GetChild(0).transform.GetChild(index).gameObject.SetActive(true);
	}
}
