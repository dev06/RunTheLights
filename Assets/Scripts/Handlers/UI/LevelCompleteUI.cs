using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LevelCompleteUI : UserInterface {

	public LevelCompletePanel stats, challenges, level, tutorialComplete;

	public Text titleText;

	private bool tutorialEnabled;


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

		level.Toggle(false);

		tutorialComplete.Toggle(false);

		tutorialEnabled = GameController.TutorialEnabled;
	}


	public void TogglePanel(LevelCompletePanel.PanelType pt)
	{
		Toggle(true);
		stats.Toggle(stats.type == pt);
		challenges.Toggle(challenges.type == pt);
		level.Toggle(level.type == pt);
		tutorialComplete.Toggle(tutorialComplete.type == pt);
		titleText.text = tutorialEnabled ? "Tutorial Complete!" :  GameController.SESSION_SCORE.ToString();
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

				if (MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock != null && MapSelectUI.SelectedMap.mapUnlockConditions.targetMapToUnlock.isUnlocked == false && !tutorialEnabled)
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
			case ButtonID.Next_TutorialComplete:
			{
				TogglePanel(LevelCompletePanel.PanelType.Level);
				break;
			}
		}
	}

	IEnumerator IDisplayLevelCompleteUI()
	{
		yield return new WaitForSeconds(2f);

		LevelCompletePanel.PanelType openPanel = tutorialEnabled ? LevelCompletePanel.PanelType.TutorialComplete : LevelCompletePanel.PanelType.Stats;
		TogglePanel(openPanel);
	}
}
