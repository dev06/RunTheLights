using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelProgression : MonoBehaviour {

	public Image foreground;
	public Text currentLevelText;
	public Text nextLevelText;


	void OnEnable()
	{
		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;
	}
	void OnDisable()
	{
		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;
	}

	void Start()
	{
		UpdateUI();
		UpdateLevelProgressionTexts();
	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (type == ProgressionColliderType.Intersection)
		{
			GameController.Instance.LightsRanInLevel++;
			UpdateUI();
		}
	}

	private void UpdateLevelProgressionTexts()
	{
		currentLevelText.text = LevelController.LEVEL.ToString();
		nextLevelText.text = (LevelController.LEVEL + 1).ToString();
	}

	public void UpdateUI ()
	{
		foreground.fillAmount = ((float)GameController.Instance.LightsRanInLevel / (float)LevelController.CHANGE_LEVEL_EVERY);
	}
}
