using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowcaseUI : MonoBehaviour {

	public CanvasGroup ui_selectButton;
	public CanvasGroup  ui_conditionText;

	void OnEnable()
	{
		EventManager.OnShowcaseModelHover += OnShowcaseModelHover;

		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;
	}
	void OnDisable()
	{
		EventManager.OnShowcaseModelHover -= OnShowcaseModelHover;

		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;
	}

	void OnShowcaseModelHover(ShowcaseModel model)
	{
		bool unlocked = model.isUnlocked();

		ui_selectButton.alpha = unlocked ? 1f : 0f;
		ui_selectButton.blocksRaycasts = unlocked;

		ui_conditionText.alpha = !unlocked ? 1f : 0f;
		ui_conditionText.blocksRaycasts = !unlocked;

		ui_conditionText.transform.GetComponent<Text>().text = model.lockMessage;



	}

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		//	Debug.Log("Selected Model: " + model);
	}


	void Start ()
	{

	}

	void Update () {

	}
}
