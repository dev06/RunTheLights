using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public static LevelController Instance;

	public static int LEVEL = 2;

	public static int CHANGE_LEVEL_EVERY;

	[HideInInspector]
	public float current_exp, target_exp;

	void Awake ()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	public void Init()
	{
		CHANGE_LEVEL_EVERY = 10;

		current_exp = PlayerPrefs.HasKey("current_exp") ? PlayerPrefs.GetFloat("current_exp") : 0f;

		target_exp = PlayerPrefs.HasKey("target_exp") ? PlayerPrefs.GetFloat("target_exp") : 10f;

		LEVEL = PlayerPrefs.HasKey("LEVEL") ? PlayerPrefs.GetInt("LEVEL") : 0;
	}

	void OnEnable()
	{
		EventManager.OnLevelComplete += OnLevelComplete;
	}
	void OnDisable()
	{
		EventManager.OnLevelComplete -= OnLevelComplete;
	}

	private void OnLevelComplete()
	{
		GameController.Instance.Save();
	}

	public void AddExperience(float exp)
	{
		current_exp += exp;

		if (current_exp >= target_exp)
		{
			float difference = current_exp - target_exp;
			LEVEL++;
			target_exp += 10;
			current_exp = difference;
		}

		PlayerPrefs.SetFloat("current_exp", current_exp);
		PlayerPrefs.SetFloat("target_exp", target_exp);
		PlayerPrefs.SetInt("LEVEL", LEVEL);
	}

	public float GetProgress()
	{
		return current_exp / target_exp;
	}


	public SectionCategory GetSectionCategoryFromLevel()
	{
		int index = (int)MapSelectUI.SelectedMap.type;

		return (SectionCategory)index;
	}


}
