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

		CHANGE_LEVEL_EVERY = GameController.Instance.ShortLevels ? 3 : MapSelectUI.SelectedMap.Length;

		current_exp = PlayerPrefs.HasKey("current_exp") ? PlayerPrefs.GetFloat("current_exp") : 0f;

		target_exp = PlayerPrefs.HasKey("target_exp") ? PlayerPrefs.GetFloat("target_exp") : 10f;

		LEVEL = PlayerPrefs.HasKey("LEVEL") ? PlayerPrefs.GetInt("LEVEL") : 0;

		FacebookManager.instance.EventSent("LEVEL_" + LEVEL);

	}

	void OnEnable()
	{
		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnMapSelected += OnMapSelected;
	}
	void OnDisable()
	{
		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnMapSelected -= OnMapSelected;
	}

	void OnMapSelected(Map m)
	{
		CHANGE_LEVEL_EVERY = m.Length;
	}

	private void OnLevelComplete()
	{

		FacebookManager.instance.EventSent("LEVEL_COMPLETE");
		FacebookManager.instance.EventSent("LEVEL_COMPLETED_" + MapSelectUI.SelectedMap.GetDisplayName());

		GameController.Instance.Save();
	}

	public void AddExperience(float exp)
	{
		current_exp += exp;
	}

	public bool CheckForLevelIncrement()
	{
		if (current_exp >= target_exp)
		{
			float difference = current_exp - target_exp;
			LEVEL++;
			target_exp += 5;
			current_exp = difference;

			return true;
		}

		return false;
	}

	public float GetProgress()
	{
		return current_exp / target_exp;
	}

	public float CurrentExp
	{
		get {return current_exp; }
		set { this.current_exp = value; }
	}

	public float TargetExp
	{
		get {return target_exp; }
		set {this.target_exp = value; }
	}


	public SectionCategory GetSectionCategoryFromLevel()
	{
		int index = (int)MapSelectUI.SelectedMap.type;

		return (SectionCategory)index;
	}


}
