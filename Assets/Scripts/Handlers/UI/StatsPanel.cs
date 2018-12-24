using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatsPanel : LevelCompletePanel {


	public Text score;
	public Text damageDealt;
	public Text furyBonus;
	public Text totalGearsCollected;


	public override void UpdateValues()
	{
		base.UpdateValues();
		int total = GameController.Instance.furyBonus + GameController.Instance.gearsCollected;
		float damage = total * ( GameController.Instance.damageDone);
		float net = total - damage;

		furyBonus.text = "+ " + GameController.Instance.furyBonus;
		damageDealt.text = "- " + damage.ToString("F0");
		string prefix = (net >= 0) ? "+ " : "- ";
		totalGearsCollected.text =  prefix + (Mathf.Abs(net)).ToString("F0");

		MapSelectUI.SelectedMap.UpdateValues();

		score.text = GameController.SESSION_SCORE.ToString();
	}
}
