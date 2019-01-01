using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Map : MonoBehaviour, IPointerClickHandler {

	public bool isUnlocked;
	public MapUnlockConditions mapUnlockConditions;
	public MapStatistics mapStats;
	public float carDelay;
	public int Length = 10;
	private Toggle toggle;

	private MapSelectUI mapSelectUI;

	public enum Type
	{
		None,
		Buildings,
		Neighborhood,
		Jungle,
		Construction,
	}

	public Type type;

	void OnEnable()
	{
		EventManager.OnLogMapStat += OnLogMapStat;
	}
	void OnDisable()
	{
		EventManager.OnLogMapStat -= OnLogMapStat;
	}

	public void Init()
	{
		toggle = GetComponent<Toggle>();

		mapSelectUI = FindObjectOfType<MapSelectUI>();

		mapStats.map = this;
		mapStats.Load();

		mapUnlockConditions.map = this;
		mapUnlockConditions.UpdateProgressValues();


		if (!PlayerPrefs.HasKey("SelectedMap"))
		{
			if (type == Type.Buildings && MapSelectUI.SelectedMap == null)
			{
				MapSelectUI.SelectedMap = this;

				SetToggle(true);
			}
		}
		else
		{
			if (type == (Type)PlayerPrefs.GetInt("SelectedMap"))
			{
				if (this.isUnlocked)
				{
					MapSelectUI.SelectedMap = this;
					SetToggle(true);
				}
				else
				{
					MapSelectUI.SelectedMap = mapSelectUI.DefaultMap;
					MapSelectUI.SelectedMap.SetToggle(true);
				}
			}
		}
	}

	public void UpdateToggleValues(Toggle[] challengeToggles)
	{
		if (mapUnlockConditions.previousMap == null)
		{
			Debug.Log("mapUnlockConditions is null");
			return;
		}
		MapUnlockConditions conditions = mapUnlockConditions.previousMap.mapUnlockConditions;

		challengeToggles[0].isOn = conditions.hasBronze();
		challengeToggles[1].isOn = conditions.hasSilver();
		challengeToggles[2].isOn = conditions.hasGold();
		challengeToggles[3].isOn = conditions.hasSpecial();
	}

	public void UpdateTextValues(Text[] challengeLabels, string labelMessage)
	{
		MapUnlockConditions conditions = mapUnlockConditions.previousMap.mapUnlockConditions;
		challengeLabels[0].text = conditions.bronzeTarget.ToString();
		challengeLabels[1].text = conditions.silverTarget.ToString();
		challengeLabels[2].text = conditions.goldTarget.ToString();
		challengeLabels[3].text = conditions.specialConditionMessage() + " [" + conditions.specialConditionProgress + "/" + conditions.specialConditionTarget + "]";
		challengeLabels[4].text = labelMessage;

	}

	public void UpdateValues()
	{
		if (MapSelectUI.SelectedMap.type != type) return;

		if (GameController.SESSION_SCORE > mapStats.Score)
		{

			mapStats.Score = GameController.SESSION_SCORE;
		}

		mapStats.Save();

		mapUnlockConditions.UpdateProgressValues();

		CheckForMapUnlocks();
	}


	public void CheckForMapUnlocks()
	{
		if (mapUnlockConditions.targetMapToUnlock != null &&  mapUnlockConditions.canUnlockTargetMap())
		{
			mapUnlockConditions.targetMapToUnlock.isUnlocked = true;
		}
		if (type == Type.Buildings)
		{
			isUnlocked = true;
		}

		toggle.interactable = isUnlocked;
	}

	public void SetToggle(bool b)
	{
		toggle.isOn = b;
	}

	public string GetDisplayName()
	{
		switch (type)
		{
			case Type.Buildings:
			{
				return "Downtown";
			}
			case Type.Neighborhood:
			{
				return "Neighborhood";
			}
			case Type.Jungle:
			{
				return "Jungle";
			}
			case Type.Construction:
			{
				return "Construction";
			}
		}

		return "No Name";
	}


	public virtual void OnPointerClick(PointerEventData data)
	{
		if (!isUnlocked)
		{
			mapSelectUI.ToggleChallengePanelPopup(true);
			UpdateToggleValues(mapSelectUI.challengeToggles);
			UpdateTextValues(mapSelectUI.challengeLabels, mapUnlockConditions.previousMap.GetDisplayName());
			return;
		}

		if (toggle.isOn)
		{
			MapSelectUI.SelectedMap = this;

			if (EventManager.OnMapSelected != null)
			{
				EventManager.OnMapSelected(this);
			}

			SetToggle(true);
		}
	}

	void OnLogMapStat(MapUnlockConditions.SpecialConditionType t, int value)
	{
		if (MapSelectUI.SelectedMap.type != type) return;

		switch (t)
		{
			case MapUnlockConditions.SpecialConditionType.NearMiss:
			{
				mapStats.NumberOfNearMisses += value;
				break;
			}

			case MapUnlockConditions.SpecialConditionType.RanLights:
			{
				mapStats.NumberOfLightsRan += value;
				break;
			}
			case MapUnlockConditions.SpecialConditionType.CarsCrashed:

			{
				mapStats.NumberOfCarsCrashed += value;
				break;
			}

			case MapUnlockConditions.SpecialConditionType.FuryAchieved:
			{
				mapStats.NumberOfFuryAchieved += value;
				break;
			}

			case MapUnlockConditions.SpecialConditionType.ZeroDamage:
			{
				mapStats.NumberOfZeroDamage += value;
				break;
			}

		}
	}
}


[System.Serializable]
public class MapStatistics
{
	public Map map;
	public int Score;
	public int NumberOfNearMisses;
	public int NumberOfLightsRan;
	public int NumberOfCarsCrashed;
	public int NumberOfFuryAchieved;
	public int NumberOfZeroDamage;

	public void Save()
	{
		PlayerPrefs.SetInt(map.GetDisplayName() + "_Score", Score);
		PlayerPrefs.SetInt(map.GetDisplayName() + "_NumberOfNearMisses", NumberOfNearMisses);
		PlayerPrefs.SetInt(map.GetDisplayName() + "_NumberOfLightsRan", NumberOfLightsRan);
		PlayerPrefs.SetInt(map.GetDisplayName() + "_NumberOfCarsCrashed", NumberOfCarsCrashed);
		PlayerPrefs.SetInt(map.GetDisplayName() + "_NumberOfFuryAchieved", NumberOfFuryAchieved);
		PlayerPrefs.SetInt(map.GetDisplayName() + "_NumberOfZeroDamage", NumberOfZeroDamage);

	}

	public void Load()
	{
		Score = PlayerPrefs.HasKey(map.GetDisplayName() + "_Score") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_Score", Score) : 0;
		NumberOfNearMisses = PlayerPrefs.HasKey(map.GetDisplayName() + "_NumberOfNearMisses") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_NumberOfNearMisses", NumberOfNearMisses) : 0;
		NumberOfLightsRan = PlayerPrefs.HasKey(map.GetDisplayName() + "_NumberOfLightsRan") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_NumberOfLightsRan", NumberOfLightsRan) : 0;
		NumberOfCarsCrashed = PlayerPrefs.HasKey(map.GetDisplayName() + "_NumberOfCarsCrashed") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_NumberOfCarsCrashed", NumberOfCarsCrashed) : 0;
		NumberOfFuryAchieved = PlayerPrefs.HasKey(map.GetDisplayName() + "_NumberOfFuryAchieved") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_NumberOfFuryAchieved", NumberOfFuryAchieved) : 0;
		NumberOfZeroDamage = PlayerPrefs.HasKey(map.GetDisplayName() + "_NumberOfZeroDamage") ? PlayerPrefs.GetInt(map.GetDisplayName() + "_NumberOfZeroDamage") : 0;
	}
}


[System.Serializable]
public class MapUnlockConditions
{

	public Map map;
	[SerializeField]
	public int bronzeTarget;
	[SerializeField]
	public int silverTarget;
	[SerializeField]
	public int goldTarget;

	public Map targetMapToUnlock;
	public Map previousMap;
	public SpecialConditionType specialCondition;
	public int specialConditionTarget;




	public int scoreProgress;

	public int specialConditionProgress;

	public bool forceUnlock;

	public enum SpecialConditionType
	{
		None,
		NearMiss,
		RanLights,
		CarsCrashed,
		FuryAchieved,
		ZeroDamage,
	}

	public bool canUnlockTargetMap()
	{
		if (forceUnlock || GameController.Instance.UnlockMaps) return true;

		if (map.mapStats.Score >= goldTarget && specialConditionProgress >= specialConditionTarget)
		{
			return true;
		}

		return false;
	}

	public void UpdateProgressValues()
	{
		switch (specialCondition)
		{
			case SpecialConditionType.NearMiss:
			{
				specialConditionProgress = map.mapStats.NumberOfNearMisses;
				break;
			}
			case SpecialConditionType.RanLights:
			{
				specialConditionProgress = map.mapStats.NumberOfLightsRan;
				break;
			}
			case SpecialConditionType.CarsCrashed:
			{
				specialConditionProgress = map.mapStats.NumberOfCarsCrashed;
				break;
			}
			case SpecialConditionType.FuryAchieved:
			{
				specialConditionProgress = map.mapStats.NumberOfFuryAchieved;
				break;
			}

			case SpecialConditionType.ZeroDamage:
			{
				specialConditionProgress = map.mapStats.NumberOfZeroDamage;
				break;
			}
		}

		specialConditionProgress = Mathf.Clamp(specialConditionProgress, 0, specialConditionTarget);
	}

	public bool hasBronze()
	{
		return map.mapStats.Score >= bronzeTarget;
	}

	public bool hasSilver()
	{
		return map.mapStats.Score >= silverTarget;
	}

	public bool hasGold()
	{
		return map.mapStats.Score >= goldTarget;
	}

	public bool hasSpecial()
	{
		return specialConditionProgress >= specialConditionTarget;
	}

	public string specialConditionMessage()
	{
		switch (specialCondition)
		{
			case SpecialConditionType.NearMiss:
			{

				return "Get " + specialConditionTarget + " Near Misses";
			}
			case SpecialConditionType.RanLights:
			{
				return "Run " + specialConditionTarget + " Lights";
			}
			case SpecialConditionType.CarsCrashed:
			{
				return "Crash into " + specialConditionTarget + " cars";
			}
			case SpecialConditionType.FuryAchieved:
			{
				return "Achieve Fury " + specialConditionTarget + " times";
			}

			case SpecialConditionType.ZeroDamage:
			{
				return "Complete level with no vehicle damage.";
			}

		}

		return "message not found";
	}
}
