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

	void OnEnable()
	{
		EventManager.OnHitObject += OnHitObject;
	}

	void OnDisable()
	{
		EventManager.OnHitObject -= OnHitObject;
	}

	void OnHitObject ()
	{
	}

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

		velocity = Mathf.Clamp(velocity, 0, Section.MAX_VELOCITY);

		Section.VELOCITY = velocity;



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

		// diff = Mathf.Clamp(diff, 0f, 20f);

		// float min = -10f;
		// float max = 10f;
		// float range = Mathf.Clamp(currentPosition.x, min, max);

		// float scaled = (range - min) / (max - min);

		// Debug.Log(scaled);

		// if(currentPosition.x > lastPosition.x)
		// {
		// 	rot-= Time.deltaTime * diff * senstivity;
		// }
		// else if(currentPosition.x < lastPosition.x)
		// {
		// 	rot+= Time.deltaTime * diff * senstivity;
		// }



		lastPosition = currentPosition;


	}

	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Objects/Car")
		{
			Death(col);
#if !UNITY_EDITOR

#endif
		}
	}

	void Death(Collider col)
	{
		GameController.GameOver = true;
		StopCoroutine("IOnDeath");
		StartCoroutine("IOnDeath");
		explosion.Play();
		col.transform.gameObject.SetActive(false);
		Toggle(false);
	}

	void Toggle(bool b)
	{
		GetComponent<MeshRenderer>().enabled = b;
		GetComponent<BoxCollider>().enabled = b;
	}

	IEnumerator IOnDeath()
	{
		yield return new WaitForSeconds(2.5f);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}
}
