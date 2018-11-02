using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuryMeter : MonoBehaviour {

	public Image foreground;

	private FuryHandler furyHandler;

	void Start ()
	{
		furyHandler = FindObjectOfType<FuryHandler>();
	}

	void Update ()
	{
		foreground.fillAmount = furyHandler.FuryTime / 3f;
	}
}
