using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUI : UserInterface {


	public CanvasGroup regularUI, showcaseUI;

	public Image vibrationImage;

	public Sprite vibrateOn, vibrateOff;

	public Text levelText;
	public Image fill;

	public override void Init()
	{
		base.Init();
		ToggleShowcaseUI(false);
		vibrationImage.sprite = Haptic.Enabled ? vibrateOn : vibrateOff;
	}

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
		EventManager.OnHitObject += OnHitObject;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnHitObject -= OnHitObject;
	}

	void Start()
	{
		levelText.text = "Level " + LevelController.LEVEL;
		fill.fillAmount = LevelController.Instance.GetProgress();
	}

	void OnButtonClick(ButtonID buttonID)
	{
		if (buttonID == ButtonID.Showcase)
		{
			EnableShowcase();
		}

		if (buttonID == ButtonID.Back)
		{
			DisableShowcase();
		}

		if (buttonID == ButtonID.VibrateToggle)
		{
			GameController.Instance.ToggleVibration(!Haptic.Enabled);
			vibrationImage.sprite = Haptic.Enabled ? vibrateOn : vibrateOff;
		}
	}

	public void EnableShowcase()
	{
		if (EventManager.OnShowcaseEnable != null)
		{
			EventManager.OnShowcaseEnable();
		}

		ToggleShowcaseUI(true);

		GameController.INSHOWCASE = true;
	}

	public void DisableShowcase()
	{
		if (EventManager.OnShowcaseDisable != null)
		{
			EventManager.OnShowcaseDisable();
		}

		ToggleShowcaseUI(false);

		GameController.INSHOWCASE = false;

	}

	private void ToggleShowcaseUI(bool b)
	{
		showcaseUI.alpha = b ? 1 : 0;
		showcaseUI.blocksRaycasts = b;

		regularUI.alpha = b ? 0 : 1;
		regularUI.blocksRaycasts = !b;
	}

	private void OnHitObject()
	{
		Toggle(false);
	}
}
