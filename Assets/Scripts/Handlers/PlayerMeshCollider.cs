using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeshCollider : MonoBehaviour {

	public ParticleSystem explosion;

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
