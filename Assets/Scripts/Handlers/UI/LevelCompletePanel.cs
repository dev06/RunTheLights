using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletePanel : MonoBehaviour {


	public enum PanelType
	{
		Stats,
		Challenges,
		Level,
		TutorialComplete,
	}


	public PanelType type;

	private CanvasGroup canvasGroup;


	public  Animation animation;

	public bool isOn;
	public virtual void Toggle(bool b)
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}
		canvasGroup.alpha = b ? 1 : 0;
		canvasGroup.blocksRaycasts = b;

		if (animation == null)
		{
			animation = GetComponent<Animation>();
		}


		isOn = b;
		if (b)
			UpdateValues();
	}

	public virtual void UpdateValues()
	{

	}
}
