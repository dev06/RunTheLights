using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ModelType
{
	None,
	Car_Regular,
	Car,
	Bike,
	Cop,

}
public class ShowcaseModel : MonoBehaviour {


	public ModelType modelType;
	[HideInInspector]
	public string lockMessage;
	private bool showLog = false;
	private Quaternion defaultRotation, targetRotation;
	private Vector3 defaultScale, targetScale;
	private float rotationSpeed;
	private bool selected;
	private MeshRenderer renderer;
	private bool unlockAll = false;

	public float speed;
	public float acceleration;
	public float deceleration;
	public float power;

	public float movementMultiplier;
	public UnlockConditions[] unlockConditions;

	void Start ()
	{
		defaultRotation = transform.localRotation;
		defaultScale = transform.localScale;

		targetRotation = defaultRotation;
		targetScale = defaultScale;

		renderer = GetComponent<MeshRenderer>();

		bool unlocked = isUnlocked();

		for (int i = 0; i < renderer.materials.Length; i++)
		{
			renderer.materials[i].SetColor("_Color", !unlocked ? Color.black : Color.white);
		}

		if (!unlocked)
		{
			foreach (Transform t in transform)
			{
				t.gameObject.SetActive(false);
			}
		}

		speed = Mathf.Clamp(speed, 0, GameController.MAX_CAR_SPEED);
		acceleration = Mathf.Clamp(acceleration, 0, GameController.MAX_CAR_ACC);
		deceleration = Mathf.Clamp(deceleration, 0, GameController.MAX_CAR_DEC);
		power = Mathf.Clamp(power, 0, GameController.MAX_CAR_POWER);
	}

	void Update ()
	{
		if (selected)
		{
			transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed, Space.World);
		}
		else
		{
			transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * 10f);
		}

		transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * 10f);
	}

	public void ResetTransform()
	{
		targetScale = defaultScale;
		targetRotation = defaultRotation;
		rotationSpeed = 0;
		selected = false;
	}

	public void Select()
	{
		targetScale = defaultScale * 1.7f;
		rotationSpeed = 50f;
		selected = true;
	}

	public bool isUnlocked()
	{
		bool unlocked = false;

		if (unlockAll)
		{
			unlocked = true;
			return unlocked;
		}

		if (unlockConditions.Length == 0)
		{
			unlocked = true;
			return unlocked;
		}

		for (int i = 0 ; i < unlockConditions.Length; i++)
		{
			unlocked = unlockConditions[i].Check();

			if (unlocked)
			{
				if (showLog)
				{
					Debug.Log(gameObject.name + " | Condition " + unlockConditions[i].conditionType + " is met ");
				}
				break;
			}
		}

		if (!unlocked && showLog)
		{
			Debug.Log(gameObject.name + " | None of the conditions are met");
		}

		if (unlockConditions.Length > 0)
		{
			lockMessage = "Either\n" + unlockConditions[0].message + "\nor\n" + unlockConditions[1].message;
		}


		return true;
	}
}

[System.Serializable]
public class UnlockConditions
{


	[SerializeField]
	public ConditionType conditionType;
	[SerializeField]
	public int target;

	[HideInInspector]
	public string message;


	public bool Check()
	{
		switch (conditionType)
		{
			case ConditionType.Distance:
			{
				message = "Travel " + target + " meters";
				return CheckDistance();
			}

			case ConditionType.Score:
			{
				message = "Score " + target + " points";
				return CheckScore();
			}

			case ConditionType.GamesPlayed:
			{
				message = "Play " + target + " games \n[" + GameController.GAMES_PLAYED + " / " + target + "]";
				return CheckGamesPlayed();
			}

			case ConditionType.LightsRan:
			{
				message = "Run " + target + " red lights \n[" + GameController.LIGHTS_RAN + " / " + target + "]";
				return CheckLightsRan();
			}
		}

		return false;
	}


	public bool CheckScore()
	{
		return GameController.BEST_SCORE >= target;
	}

	public bool CheckGamesPlayed()
	{
		return GameController.GAMES_PLAYED >= target;;
	}

	public bool CheckDistance()
	{
		return GameController.BEST_DISTANCE >= target;
	}

	public bool CheckLightsRan()
	{
		return GameController.LIGHTS_RAN >= target;
	}
}

public enum ConditionType
{
	None,
	Score,
	GamesPlayed,
	Distance,
	LightsRan,

}

