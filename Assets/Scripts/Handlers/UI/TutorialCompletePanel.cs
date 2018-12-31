using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialCompletePanel : LevelCompletePanel {



	public override void UpdateValues()
	{
		base.UpdateValues();
		GameController.Instance.GearsRemaining += 200;
		PlayerPrefs.SetInt("GearsRemaining", GameController.Instance.GearsRemaining);
		animation.Play();
	}


}
