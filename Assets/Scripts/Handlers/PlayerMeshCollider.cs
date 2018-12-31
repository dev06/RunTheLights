using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeshCollider : MonoBehaviour {

	public ParticleSystem explosion;

	public Transform trail;

	private CameraController cameraController;

	private bool furyHitThresholdReach = true;

	private GameInput player;

	void OnEnable()
	{
		EventManager.OnFuryStatus += OnFuryStatus;

		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;

		EventManager.OnGameStart += OnGameStart;


	}
	void OnDisable()
	{
		EventManager.OnFuryStatus -= OnFuryStatus;

		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;

		EventManager.OnGameStart -= OnGameStart;


	}

	void Start()
	{
		cameraController = CameraController.Instance;

		player = FindObjectOfType<GameInput>();

		player.VehicleDurability = GameController.ActiveModel.durability.value;
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

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		player.VehicleDurability = model.durability.value;
	}

	void OnGameStart()
	{
		player.VehicleDurability = GameController.ActiveModel.durability.value;
	}

	IEnumerator IWait()
	{
		yield return new WaitForSeconds(1f);

		furyHitThresholdReach = true;
	}


	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Trigger/StartGame")
		{

			if (EventManager.OnGameStart != null)
			{
				EventManager.OnGameStart();
			}
		}


		if (col.gameObject.tag == "Trigger/StopProgressionCollider")
		{
			cameraController.InStopZone = true;
		}

		if (col.gameObject.tag == "Objects/Car")
		{
			if (EventManager.OnLogMapStat != null)
			{
				EventManager.OnLogMapStat(MapUnlockConditions.SpecialConditionType.CarsCrashed, 1);
			}

			if (FuryHandler.InFury)
			{
				TriggerVehicleCrash(col);
			}
			else
			{
				if (furyHitThresholdReach)
				{
					player.VehicleDurability--;

					GameController.Instance.damageDone = (int)GameController.ActiveModel.durability.value - (int)player.VehicleDurability;

					if (player.VehicleDurability < 0)
					{
						if (GameController.Instance.CanDie)
						{
							Death(col);
						}

						player.VehicleDurability = 0;
					}
					else
					{
						TriggerVehicleCrash(col);
					}

					if (EventManager.OnVehicleHit != null)
					{
						EventManager.OnVehicleHit();
					}

					col.gameObject.GetComponent<Car>().CarHit = true;
				}
			}
		}

		if (col.gameObject.tag == "Objects/Gear")
		{
			int gearMult = FuryHandler.InFury ? 2 : 1;
			GameController.Instance.gearsCollected += gearMult;

			Gear gear = col.gameObject.transform.GetComponent<Gear>();

			gear.Toggle(false);

			if (EventManager.OnGearTriggerHit != null)
			{
				EventManager.OnGearTriggerHit();
			}

		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Trigger/StopProgressionCollider")
		{
			cameraController.InStopZone = false;
		}


		if (col.gameObject.tag == "Trigger/NearMiss" && !FuryHandler.InFury)
		{
			if (col.gameObject.GetComponentInParent<Car>().CarHit == false)
			{

				if (EventManager.OnNearMiss != null)
				{
					EventManager.OnNearMiss();
				}

				if (EventManager.OnLogMapStat != null)
				{
					EventManager.OnLogMapStat(MapUnlockConditions.SpecialConditionType.NearMiss, 1);
				}
			}
		}
	}

	void TriggerVehicleCrash(Collider col)
	{
		col.transform.GetComponent<Car>().Toggle(false);
		col.transform.GetComponentInChildren<ParticleSystem>().Play();
		cameraController.TriggerShake(.75f, 15f);
		Haptic.Vibrate(HapticIntensity.Medium);
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
