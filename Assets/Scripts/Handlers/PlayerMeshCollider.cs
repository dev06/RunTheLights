using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeshCollider : MonoBehaviour {

	public ParticleSystem explosion;

	private CameraController cameraController;

	private bool furyHitThresholdReach = true;

	void OnEnable()
	{
		EventManager.OnFuryStatus += OnFuryStatus;
	}
	void OnDisable()
	{
		EventManager.OnFuryStatus -= OnFuryStatus;
	}

	void Start()
	{
		cameraController = CameraController.Instance;
	}

	void OnFuryStatus(int i)
	{
		if (i == 0)
		{
			StopCoroutine("IWait");
			StartCoroutine("IWait");
		}
		else
		{
			furyHitThresholdReach = false;
		}
	}

	IEnumerator IWait()
	{
		yield return new WaitForSeconds(.25f);

		furyHitThresholdReach = true;
	}

	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Trigger/StopProgressionCollider")
		{
			cameraController.InStopZone = true;
		}

		if (col.gameObject.tag == "Objects/Car")
		{

			if (FuryHandler.InFury)
			{
				col.transform.GetComponent<Car>().Toggle(false);
				col.transform.GetComponentInChildren<ParticleSystem>().Play();
				cameraController.TriggerShake(.75f, 15f);
				Haptic.Vibrate(HapticIntensity.Medium);
			}
			else
			{
				if (GameController.Instance.CanDie)
				{
					if (furyHitThresholdReach)
					{
						Death(col);
					}
				}
			}
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
