using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapSelectUI : MonoBehaviour {

	public static Map SelectedMap;

	public CanvasGroup regularUI, mapSelectUI;
	public CanvasGroup challengePanelPopup;
	public Map[] maps;
	public Toggle[] challengeToggles;
	public Text[] challengeLabels;

	private Animation animation;


	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
	}

	void Start()
	{

		foreach (Map m in maps)
		{
			m.Init();
			m.CheckForMapUnlocks();
		}

		animation = GetComponent<Animation>();

		ToggleMapSelectUI(false);
		ToggleChallengePanelPopup(false);

	}

	void OnButtonClick(ButtonID id)
	{
		if (id == ButtonID.MapSelect)
		{
			ToggleMapSelectUI(true);
		}

		if (id == ButtonID.Back)
		{
			ToggleMapSelectUI(false);
			PlayerPrefs.SetInt("SelectedMap", (int)(SelectedMap.type));
		}
	}


	private void ToggleMapSelectUI(bool b)
	{
		mapSelectUI.alpha = b ? 1 : 0;
		mapSelectUI.blocksRaycasts = b;

		regularUI.alpha = b ? 0 : 1;
		regularUI.blocksRaycasts = !b;

		if (b) animation.Play("MapSelect_main");
	}

	public void ToggleChallengePanelPopup(bool b)
	{
		challengePanelPopup.alpha = b ? 1 : 0;
		challengePanelPopup.blocksRaycasts = b;
		if (b) animation.Play("MapSelect_ChallengePopUI");

	}

}
