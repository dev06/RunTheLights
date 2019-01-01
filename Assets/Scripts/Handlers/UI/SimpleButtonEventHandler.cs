using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum ButtonID
{
	None,
	Showcase,
	Back,
	SelectModel,
	VibrateToggle,
	UpgradeSpeed,
	UpgradeDurability,
	UpgradeFuryTime,
	Next_Stats,
	Next_Challenges,
	ToMenu,
	MapSelect,
	Next_TutorialComplete,
	MoreInfo,
	Resume,
	RestartGame,
	Pause
}
public class SimpleButtonEventHandler : MonoBehaviour, IPointerClickHandler {


	public ButtonID buttonID;

	public virtual void OnPointerClick(PointerEventData data)
	{

		if (buttonID == ButtonID.RestartGame)
		{
			Time.timeScale = 1;

			if (EventManager.OnRestartGame != null)
			{
				EventManager.OnRestartGame();
			}
		}
		if (EventManager.OnButtonClick != null)
		{
			EventManager.OnButtonClick(buttonID);
		}
	}
}
