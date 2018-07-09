using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUI : UserInterface {


	public CanvasGroup regularUI, showcaseUI;


	public override void Init()
	{
		base.Init();
		ToggleShowcaseUI(false);
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
	}

	public void EnableShowcase()
	{
		if (EventManager.OnShowcaseEnable != null)
		{
			EventManager.OnShowcaseEnable();
		}

		ToggleShowcaseUI(true);
	}

	public void DisableShowcase()
	{
		if (EventManager.OnShowcaseDisable != null)
		{
			EventManager.OnShowcaseDisable();
		}

		ToggleShowcaseUI(false);
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
