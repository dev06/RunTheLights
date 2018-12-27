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
	Car_7,
	Car_8,
	Car_9,
}

[System.Serializable]
public class Attribute
{
	public static int MAX_TIER = 5;
	public ShowcaseModel model;
	public enum Type
	{
		Speed,
		Durability,
		furyTime
	}

	public Type attributeType;
	[Header("**********Current*********")]

	public float value;
	public int cost;

	public int tier;

	[Header("**********Default*********")]
	public float defaultValue;
	public int defaultCost;
	public int defaultTier;

	public void AddValue(float value)
	{
		this.value += value;
	}

	public void AddCost(int cost)
	{
		this.cost += cost;
	}

	public void IncrementTier()
	{
		tier++;
		tier = (int)Mathf.Clamp(tier, 0f, 5f);
	}

	public bool isMaxedOut()
	{
		return fill >= 1f;
	}

	public bool canPurchase()
	{
		bool cp = GameController.Instance.GearsRemaining >= cost;

		if (cp)
		{

			GameController.Instance.GearsRemaining -= cost;

			if (EventManager.OnVehicleUpgrade != null)
			{
				EventManager.OnVehicleUpgrade(this);
			}

			PlayerPrefs.SetInt("GearsRemaining", GameController.Instance.GearsRemaining);
		}

		return cp;
	}

	public void SaveValues()
	{
		PlayerPrefs.SetFloat(model.modelType + "_" + attributeType    +  "_value", value);
		PlayerPrefs.SetInt(model.modelType + "_" + attributeType    + "_cost", cost);
		PlayerPrefs.SetInt(model.modelType + "_" + attributeType    + "_tier", tier);

	}

	public void LoadValues()
	{
		value = PlayerPrefs.HasKey(model.modelType + "_" + attributeType +  "_value") ? PlayerPrefs.GetFloat(model.modelType + "_" + attributeType +  "_value") : defaultValue;
		cost = PlayerPrefs.HasKey(model.modelType + "_" + attributeType +  "_cost") ? PlayerPrefs.GetInt(model.modelType + "_" + attributeType +  "_cost") : defaultCost;
		tier = PlayerPrefs.HasKey(model.modelType + "_" + attributeType +  "_tier") ? PlayerPrefs.GetInt(model.modelType + "_" + attributeType +  "_tier") : defaultTier;
	}

	public float fill
	{
		get {return ((float)tier / MAX_TIER);}
	}
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

	public bool forceUnlock;
	public float acceleration;
	public float deceleration;

	public Attribute speed;
	public Attribute durability;
	public Attribute furyTime;

	public UnlockConditions[] unlockConditions;

	public Vector3 cameraPositionOffset;

	public void Init ()
	{
		defaultRotation = transform.localRotation;
		defaultScale = transform.localScale;

		targetRotation = defaultRotation;
		targetScale = defaultScale;

		speed.model = this;
		durability.model = this;
		furyTime.model = this;

		speed.LoadValues();
		durability.LoadValues();
		furyTime.LoadValues();

		renderer = GetComponent<MeshRenderer>();

		CheckForUnlocks();

		acceleration = Mathf.Clamp(acceleration, 0, GameController.MAX_CAR_ACC);
		deceleration = Mathf.Clamp(deceleration, 0, GameController.MAX_CAR_DEC);
	}

	public void CheckForUnlocks()
	{
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

	public float Speed
	{
		get { return speed.value; }
		set { this.speed.value = value;}
	}

	public void ResetTransform()
	{
		targetScale = defaultScale;
		targetRotation = defaultRotation;
		rotationSpeed = 0;
		selected = false;
	}

	public void Save()
	{
		speed.SaveValues();
		durability.SaveValues();
		furyTime.SaveValues();
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

		if (unlockConditions.Length == 0 || forceUnlock)
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

		lockMessage = unlockConditions[0].message;

		return unlocked;
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

			case ConditionType.GamesPlayed:
			{
				message = "Play " + target + " games \n[" + GameController.GAMES_PLAYED + " / " + target + "]";
				return CheckGamesPlayed();
			}

			case ConditionType.LevelReach:
			{
				message = "Unlocked at level " + target + " \n[" + LevelController.LEVEL + " / " + target + "]";
				return CheckLevelReach();
			}

		}

		return false;
	}

	public bool CheckGamesPlayed()
	{
		return GameController.GAMES_PLAYED >= target;;
	}

	public bool CheckLevelReach()
	{
		return LevelController.LEVEL >= target;
	}
}

public enum ConditionType
{
	None,
	Score,
	GamesPlayed,
	Distance,
	LightsRan,
	LevelReach,

}

