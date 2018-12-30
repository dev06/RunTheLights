using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatsPanel : LevelCompletePanel {


	public Text score;
	public Text damageDealt;
	public Text furyBonus;
	public Text totalGearsCollected;


	private int targetNet;
	private int targetDamage;
	private int targetFuryBonus;

	public Image gearsImage;


	void Update()
	{

	}

	public override void UpdateValues()
	{
		base.UpdateValues();
		if (GameController.ActiveModel == null) return;
		int total = GameController.Instance.furyBonus + GameController.Instance.gearsCollected;
		int damage = (GameController.ActiveModel.durability.tier + 1) * ( GameController.Instance.damageDone);
		int net = total - damage;


		targetNet = net;
		targetDamage =	damage;
		targetFuryBonus = GameController.Instance.furyBonus;

		StopCoroutine("IAnim");
		StartCoroutine("IAnim");
	}

	IEnumerator IAnim()
	{
		float stepDelay = .5f;
		score.text = GameController.SESSION_SCORE.ToString();
		yield return new WaitForSeconds(stepDelay);

		// targetDamage =	5;
		// targetFuryBonus = 24;
		// targetNet = 53;


		int currentDamage = 0;
		while (currentDamage < targetDamage)
		{
			currentDamage++;
			damageDealt.text = "- " + currentDamage.ToString("F0");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}
		damageDealt.text = "- " + targetDamage.ToString("F0");


		yield return new WaitForSeconds(stepDelay);

		int currentFuryBonus = 0;
		while (currentFuryBonus < targetFuryBonus)
		{
			currentFuryBonus++;
			furyBonus.text = "+ " + currentFuryBonus.ToString("F0");
			yield return new WaitForSeconds(Time.fixedDeltaTime);
		}

		furyBonus.text =  "+ " + targetFuryBonus.ToString("F0");

		yield return new WaitForSeconds(stepDelay);


		int currentTotalGears = 0;
		string prefix = (targetNet >= 0) ? " + " : " - ";
		int add = Mathf.RoundToInt((float)targetNet * .1f);

		gearsImage.enabled = true;

		add = Mathf.Clamp(add, 1, add);
		while (Mathf.Abs(currentTotalGears) < targetNet)
		{
			currentTotalGears += add;
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
