using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

	public ParticleSystem explosion;

	private float targetVelocity;

	private float vel;

	private float rate;

	private float velocity;

	private float acc;

	private bool pressed;

	void Update ()
	{
		if (GameController.GameOver)
		{
			Section.VELOCITY = 0f;
			velocity = 0f;
			return;
		}


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


		GameController.DISTANCE_TRAVELED += velocity * .02f;
		GameController.DISTANCE_TRAVELED = Mathf.Round(GameController.DISTANCE_TRAVELED * 10f) / 10f;
		GameController.DISTANCE_TRAVELED = Mathf.Clamp(GameController.DISTANCE_TRAVELED, 0, GameController.DISTANCE_TRAVELED);



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

	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Objects/Car")
		{
#if !UNITY_EDITOR
			Death(col);
#endif
		}
	}

	void Death(Collider col)
	{

		GameController.GameOver = true;
		explosion.Play();
		col.transform.gameObject.SetActive(false);
		Toggle(false);
		if (EventManager.OnGameOver != null)
		{
			EventManager.OnGameOver();
		}
	}

	void Toggle(bool b)
	{
		GetComponent<MeshRenderer>().enabled = b;
		GetComponent<BoxCollider>().enabled = b;
	}


}
