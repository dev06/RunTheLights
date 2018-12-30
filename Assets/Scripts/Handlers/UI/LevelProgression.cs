using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelProgression : MonoBehaviour {

	public Image foreground;
	public Text currentLevelText;
	public Text nextLevelText;
	private float targetFill;


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
	}

	void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (type == ProgressionColliderType.Intersection)
		{
			GameController.Instance.LightsRanInLevel++;
			UpdateUI();
		}
	}

	void Update()
	{
		foreground.fillAmount = Mathf.Lerp(foreground.fillAmount, targetFill, Time.deltaTime * 5f);
	}

	public void UpdateUI ()
	{
		targetFill = ((float)GameController.Instance.LightsRanInLevel / (float)LevelController.CHANGE_LEVEL_EVERY);
	}
}
