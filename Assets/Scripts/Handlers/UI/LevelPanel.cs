using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : LevelCompletePanel {


	public Text levelText;
	public Image fill;

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;

		EventManager.OnLevelComplete += OnLevelComplete;
	}

	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;

		EventManager.OnLevelComplete -= OnLevelComplete;
	}

	void OnButtonClick(ButtonID id)
	{
		if (id != ButtonID.ToMenu)
		{
			return;
		}

		if (EventManager.OnRestartGame != null)
		{
			EventManager.OnRestartGame();
		}
	}

	void OnLevelComplete()
	{
		LevelController.Instance.AddExperience(5);

		levelText.text = "Level " + LevelController.LEVEL;

		fill.fillAmount = LevelController.Instance.GetProgress();
	}

	public override void UpdateValues()
	{
		base.UpdateValues();
	}
}
