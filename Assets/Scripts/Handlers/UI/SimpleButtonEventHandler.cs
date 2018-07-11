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
	VibrateToggle
}
public class SimpleButtonEventHandler : MonoBehaviour, IPointerClickHandler {


	public ButtonID buttonID;

	public virtual void OnPointerClick(PointerEventData data)
	{
		if (EventManager.OnButtonClick != null)
		{
			EventManager.OnButtonClick(buttonID);
		}
	}
}
