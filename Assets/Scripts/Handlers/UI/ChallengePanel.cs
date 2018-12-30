using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengePanel : LevelCompletePanel {

	public Toggle[] challengeToggles;
	public Text[] challengeLabels;

	private MapSelectUI mapSelect;

	void Start()
	{
		mapSelect = FindObjectOfType<MapSelectUI>();
	}


	public override void UpdateValues()
	{
		base.UpdateValues();
		if (MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock == null) return;
		MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock.UpdateToggleValues(challengeToggles);
		MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock.UpdateTextValues(challengeLabels, MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock.GetDisplayName());
		animation.Play();
	}
}
