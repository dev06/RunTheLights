using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUI : UserInterface {


	public CanvasGroup regularUI, showcaseUI, helpUI;

	public Image vibrationImage;

	public Sprite vibrateOn, vibrateOff;

	public Text levelText, totalGearsText;

	public Image fill;

	private int helpHitCount;

	public override void Init()
	{
		base.Init();
		ToggleShowcaseUI(false);
		vibrationImage.sprite = Haptic.Enabled ? vibrateOn : vibrateOff;
	}

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
		EventManager.OnGameStart += OnGameStart;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
		EventManager.OnGameStart -= OnGameStart;
	}

	void Start()
	{
		UpdateUI();


		Toggle(!GameController.TutorialEnabled);

	}

	void OnButtonClick(ButtonID buttonID)
	{

		switch (buttonID)
		{
			case ButtonID.Showcase:
			{
				EnableShowcase();
				break;
			}

			case ButtonID.VibrateToggle:
			{
				GameController.Instance.ToggleVibration(!Haptic.Enabled);
				vibrationImage.sprite = Haptic.Enabled ? vibrateOn : vibrateOff;
				break;
			}
			case ButtonID.MoreInfo:
			{
				helpUI.alpha = 1;
				helpUI.blocksRaycasts = true;
				helpUI.transform.GetComponent<Animation>().Play();
				break;
			}

			case ButtonID.HelpMe:
			{
				if (GameController.Instance.GodMode) break;

				helpHitCount++;

				if (helpHitCount > 15)
				{
					GameController.Instance.ActivateGodMode();
				}

				break;
			}

			case ButtonID.Back:
			{
				if (helpUI.alpha == 1)
				{
					helpUI.alpha = 0;
					helpUI.blocksRaycasts = false;
				}
				else
				{
					DisableShowcase();
				}
				break;
			}

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

		UpdateUI();
	}

	private void OnGameStart()
	{
		Toggle(false);
	}

	private void UpdateUI()
	{
		levelText.text = "Level " + LevelController.LEVEL;
		totalGearsText.text = GameController.Instance.GearsRemaining.ToString();
		fill.fillAmount = LevelController.Instance.GetProgress();
	}

}
