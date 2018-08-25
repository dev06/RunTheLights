using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeshCollider : MonoBehaviour {

	public ParticleSystem explosion;

	private CameraController cameraController;

	void Start()
	{
		cameraController = CameraController.Instance;
	}

	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Trigger/StopProgressionCollider")
		{
			cameraController.InStopZone = true;
		}

		if (col.gameObject.tag == "Objects/Car")
		{
#if !UNITY_EDITOR
			Death(col);
			
#endif
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Trigger/StopProgressionCollider")
		{
			cameraController.InStopZone = false;
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

		transform.gameObject.SetActive(false);
	}

}
