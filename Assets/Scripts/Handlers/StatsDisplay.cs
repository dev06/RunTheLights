using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsDisplay : MonoBehaviour {

	public TextMesh textMesh;

	void Start ()
	{
		textMesh.text = "Best Distance: " + GameController.BEST_DISTANCE.ToString("F0") + "m" + "\n" + " Best Score: " + GameController.BEST_SCORE
		                + "\n Last: " +  GameController.SCORE + " | " + GameController.DISTANCE_TRAVELED.ToString("F0") + "m";
	}

}
