using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LevelCompleteUI : UserInterface {

	public LevelCompletePanel stats, challenges, level;


	void OnEnable()
	{
		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnButtonClick -= OnButtonClick;
	}


	public override void Init()
	{
		base.Init();

		Toggle(false);

		stats.Toggle(false);

		challenges.Toggle(false);

		level.Toggle(true);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			StopCoroutine("IDisplayLevelCompleteUI");

			StartCoroutine("IDisplayLevelCompleteUI");
		}
	}


	public void TogglePanel(LevelCompletePanel.PanelType pt)
	{
		Toggle(true);
		stats.Toggle(stats.type == pt);
		challenges.Toggle(challenges.type == pt);
		level.Toggle(level.type == pt);
	}

	private void OnLevelComplete()
	{
		StopCoroutine("IDisplayLevelCompleteUI");

		StartCoroutine("IDisplayLevelCompleteUI");
	}

	private void OnButtonClick(ButtonID id)
	{
		switch (id)
		{
			case ButtonID.Next_Stats:
			{

				if (MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock != null && MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock.isUnlocked == false)
				{
					TogglePanel(LevelCompletePanel.PanelType.Challenges);
				}
				else
				{
					TogglePanel(LevelCompletePanel.PanelType.Level);
				}
				break;
			}
			case ButtonID.Next_Challenges:
			{
				TogglePanel(LevelCompletePanel.PanelType.Level);
				break;
			}
		}
	}

	IEnumerator IDisplayLevelCompleteUI()
	{
		yield return new WaitForSeconds(2f);

		TogglePanel(LevelCompletePanel.PanelType.Stats);
	}
}
