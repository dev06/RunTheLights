using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void Section(SectionType type);

	public static Section OnSectionPool;


	public delegate void Gameplay();
	public static Gameplay OnHitObject;
	public static Gameplay OnUpdateUI;
	public static Gameplay OnZoneComplete;
	public static Gameplay OnGameOver;
	public static Gameplay OnGameStart;
	public static Gameplay OnShowcaseEnable;
	public static Gameplay OnShowcaseDisable;
	public static Gameplay OnFingerDown;
	public static Gameplay OnFingerUp;
	public static Gameplay OnLevelComplete;
	public static Gameplay OnGearTriggerHit;
	public static Gameplay OnVehicleHit;
	public static Gameplay OnNearMiss;
	public static Gameplay OnRestartGame;


	public delegate void Fury(int i);
	public static Fury OnFuryStatus;



	public delegate void ProgressionCollider(ProgressionColliderType type);
	public static ProgressionCollider OnProgressionColliderHit;
	public static ProgressionCollider OnProgressionColliderExit;

	public delegate void ButtonClick(ButtonID id);
	public static ButtonClick OnButtonClick;


	public delegate void Showcase(ShowcaseModel model);
	public static Showcase OnShowcaseModelHover;
	public static Showcase OnShowcaseModelSelected;

	public delegate void MapSelect(Map map);
	public static MapSelect OnMapSelected;


	public delegate void Tutorial(int step);
	public static Tutorial OnTutorialStep;


	public delegate void LogMapStats(MapUnlockConditions.SpecialConditionType t, int value);
	public static LogMapStats OnLogMapStat;

	public delegate void UpgradeVehicle(Attribute a);
	public static UpgradeVehicle OnVehicleUpgrade;

}


