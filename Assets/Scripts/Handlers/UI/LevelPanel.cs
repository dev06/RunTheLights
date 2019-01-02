using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanel : LevelCompletePanel {


	public Text levelText;
	public Image fill;

	private float targetFill;
	private LevelController level;

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

		PlayerPrefs.SetFloat("current_exp", LevelController.Instance.CurrentExp);
		PlayerPrefs.SetFloat("target_exp", LevelController.Instance.TargetExp);
		PlayerPrefs.SetInt("LEVEL", LevelController.LEVEL);

		if (EventManager.OnRestartGame != null)
		{
			EventManager.OnRestartGame();
		}
	}

	void OnLevelComplete()
	{

		levelText.text = "Level " + LevelController.LEVEL;

		targetFill =  LevelController.Instance.GetProgress();
		fill.fillAmount = targetFill;
	}

	public override void UpdateValues()
	{
		base.UpdateValues();
		animation.Play("LevelPanel");

		StopCoroutine("IAnim");
		StartCoroutine("IAnim");
	}

	void Update()
	{
		if (!isOn) return;

		if (level == null)
		{
			level = LevelController.Instance;
		}

		fill.fillAmount = Mathf.Lerp(fill.fillAmount, targetFill, Time.deltaTime * 3f);

		if (fill.fillAmount >= .99f)
		{
			fill.fillAmount = 0f;

			LevelController.Instance.CheckForLevelIncrement();

			targetFill = LevelController.Instance.GetProgress();

			levelText.text = "Level " + LevelController.LEVEL;

			if (!animation.isPlaying)
			{
				animation.Play("LevelPanel_NextLevelPop");
			}
		}

	}



	IEnumerator IAnim()
	{


		yield return new WaitForSeconds(.5f);


		LevelController.Instance.AddExperience(7 * MapSelectUI.SelectedMap.LevelExperienceMult);

		targetFill = LevelController.Instance.GetProgress();


	}
}
