﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInterface : MonoBehaviour {

	public  CanvasGroup canvasGroup;

	public virtual void Init()
	{

	}

	public virtual void Toggle(bool b)
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}

		canvasGroup.alpha = b ? 1 : 0;
		canvasGroup.blocksRaycasts = b;
	}
}
