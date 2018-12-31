using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatsPanel : LevelCompletePanel {


	public Text score;
	public Text damageDealt;
	public Text furyBonus;
	public Text gearMult;
	public Text totalGearsCollected;


	private int targetNet;
	private int targetDamage;
	private int targetFuryBonus;
	private int targetGearMult;

	public Image gearsImage;


	void Update()
	{

	}

	public override void UpdateValues()
	{
		base.UpdateValues();
		if (GameController.ActiveModel == null) return;
		int total = GameController.Instance.furyBonus + GameController.Instance.gearsCollected;
		int damage = Mathf.RoundToInt((total * .1f) * (GameController.Instance.damageDone));
		int gross = total - damage;
		int vehicleMult = Mathf.RoundToInt((total * GameController.ActiveModel.gearMultiplier));
		int net = gross + vehicleMult;


		targetNet = net;
		targetDamage =	damage;
		targetFuryBonus = GameController.Instance.furyBonus;
		targetGearMult = vehicleMult;
		StopCoroutine("IAnim");
		StartCoroutine("IAnim");
	}

	IEnumerator IAnim()
	{
		float stepDelay = .5f;
		score.text = GameController.SESSION_SCORE.ToString();
		yield return new WaitForSeconds(stepDelay);


		int currentDamage = 0;
		int add1 = Mathf.RoundToInt((float)targetDamage * .1f);
		add1 = Mathf.Clamp(add1, 1, add1);
		while (currentDamage < targetDamage)
		{
			currentDamage += add1;
			damageDealt.text = "- " + currentDamage.ToString("F0");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}
		damageDealt.text = "- " + targetDamage.ToString("F0");


		yield return new WaitForSeconds(stepDelay);

		int currentFuryBonus = 0;
		int add2 = Mathf.RoundToInt((float)targetFuryBonus * .1f);
		add2 = Mathf.Clamp(add2, 1, add2);
		while (currentFuryBonus < targetFuryBonus)
		{
			currentFuryBonus += add2;
			furyBonus.text = "+ " + currentFuryBonus.ToString("F0");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}

		furyBonus.text =  "+ " + targetFuryBonus.ToString("F0");


		yield return new WaitForSeconds(stepDelay);


		int currentGearMult = 0;
		int add3 = Mathf.RoundToInt((float)targetGearMult * .1f);
		add3 = Mathf.Clamp(add3, 1, add3);
		while (currentGearMult < targetGearMult)
		{
			currentGearMult += add3;
			gearMult.text = "+ " + currentGearMult.ToString("F0");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}

		gearMult.text =  "+ " + targetGearMult.ToString("F0");





		yield return new WaitForSeconds(stepDelay);


		int currentTotalGears = 0;
		string prefix = (targetNet >= 0) ? " + " : " - ";


		gearsImage.enabled = true;
		int add4 = Mathf.RoundToInt((float)targetNet * .1f);
		add4 = Mathf.Clamp(add4, 1, add4);
		while (Mathf.Abs(currentTotalGears) < targetNet)
		{
			currentTotalGears += add4;
			totalGearsCollected.text =  prefix + Mathf.Abs(currentTotalGears).ToString("F0");
			animation.Play("StatsPanel_TotalGearsPop");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}

		totalGearsCollected.text =  prefix + Mathf.Abs(targetNet).ToString("F0");

		GameController.Instance.GearsRemaining += targetNet;
		MapSelectUI.SelectedMap.UpdateValues();
		PlayerPrefs.SetInt("GearsRemaining", GameController.Instance.GearsRemaining);

		animation.Play("StatsPanel");
	}
}
