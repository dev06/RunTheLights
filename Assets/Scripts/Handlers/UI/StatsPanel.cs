using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatsPanel : LevelCompletePanel {


	public Text score;
	public Text damageDealt;
	public Text furyBonus;
	public Text totalGearsCollected;


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

		furyBonus.text = "+ " + GameController.Instance.furyBonus;
		damageDealt.text = "- " + damage.ToString("F0");
		string prefix = (net >= 0) ? "+ " : "- ";
		totalGearsCollected.text =  prefix + (Mathf.Abs(net)).ToString("F0");
		GameController.Instance.GearsRemaining += net;
		MapSelectUI.SelectedMap.UpdateValues();
		score.text = GameController.SESSION_SCORE.ToString();
		PlayerPrefs.SetInt("GearsRemaining", GameController.Instance.GearsRemaining);

	}
}
