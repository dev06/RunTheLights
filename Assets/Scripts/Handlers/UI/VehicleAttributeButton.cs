using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VehicleAttributeButton : MonoBehaviour {

	public Text costText;
	public Text valueText;
	public Image fillImage;

	private float targetFillAmount;
	private float vel;

	void Update()
	{
		fillImage.fillAmount = Mathf.SmoothDamp(fillImage.fillAmount, targetFillAmount, ref vel, Time.deltaTime * 10f);
	}

	public string CostText
	{
		set {costText.text = value; }
		get {return this.costText.text;}
	}

	public string ValueText
	{
		set {valueText.text = value; }
		get {return this.valueText.text;}
	}

	public float FillAmount
	{
		set {targetFillAmount = value; }
		get {return fillImage.fillAmount; }
	}

	public void TriggerPop()
	{
		GetComponent<Animation>().Play();
	}
}
