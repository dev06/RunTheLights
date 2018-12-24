using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowcaseUI : MonoBehaviour {

	public CanvasGroup ui_selectButton;
	public CanvasGroup ui_conditionText;
	public CanvasGroup ui_upgrades;
	public VehicleUpgradeHandler upgradeHandler;
	public Transform selectedButton;

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
		ui_upgrades.alpha = unlocked ? 1f : 0f;
		ui_upgrades.blocksRaycasts = unlocked;

		ui_conditionText.alpha = !unlocked ? 1f : 0f;
		ui_conditionText.blocksRaycasts = !unlocked;

		ui_conditionText.transform.GetComponent<Text>().text = model.lockMessage;

		ToggleActiveSelectButton((model.modelType == GameController.ActiveModel.modelType));

		upgradeHandler.UpdateUpgradeUI(model);
	}

	void OnShowcaseModelSelected(ShowcaseModel model)
	{
		ToggleActiveSelectButton((model.modelType == GameController.ActiveModel.modelType));

	}


	void ToggleActiveSelectButton(bool b)
	{
		selectedButton.GetComponent<Image>().color = b ? new Color(0 / 255f, 154f / 255f, 255F / 255f, 1f) : new Color(1, 1, 1, 1);


		Text text = selectedButton.GetComponentInChildren<Text>();
		text.color = b ? Color.white : Color.black;

		text.text = b ? "Active" : "Select";
	}
}
