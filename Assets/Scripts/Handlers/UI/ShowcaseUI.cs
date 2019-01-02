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
	public Text totalGearsCollected;
	private Animation animation;

	private Text selectedButtonText;

	void OnEnable()
	{
		EventManager.OnShowcaseModelHover += OnShowcaseModelHover;

		EventManager.OnShowcaseModelSelected += OnShowcaseModelSelected;

		EventManager.OnShowcaseEnable += OnShowcaseEnable;

		EventManager.OnVehicleUpgrade += OnVehicleUpgrade;
	}
	void OnDisable()
	{
		EventManager.OnShowcaseModelHover -= OnShowcaseModelHover;

		EventManager.OnShowcaseModelSelected -= OnShowcaseModelSelected;

		EventManager.OnShowcaseEnable -= OnShowcaseEnable;

		EventManager.OnVehicleUpgrade -= OnVehicleUpgrade;
	}

	void Start()
	{
		selectedButtonText = selectedButton.GetComponentInChildren<Text>();
	}

	void OnShowcaseEnable()
	{
		totalGearsCollected.text = GameController.Instance.GearsRemaining.ToString();
		GetComponent<Animation>().Play();
	}

	void OnVehicleUpgrade(Attribute a)
	{
		totalGearsCollected.text = GameController.Instance.GearsRemaining.ToString();
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
		if (selectedButtonText.text != "Active")
			selectedButton.GetComponent<Animation>().Play();
		ToggleActiveSelectButton((model.modelType == GameController.ActiveModel.modelType));

	}


	void ToggleActiveSelectButton(bool b)
	{

		selectedButton.GetComponent<Image>().color = b ? new Color(0 / 255f, 154f / 255f, 255F / 255f, 1f) : new Color(1, 1, 1, 1);


		selectedButtonText.color = b ? Color.white : Color.black;

		selectedButtonText.text = b ? "Active" : "Select";
	}
}
