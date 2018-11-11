using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsDisplay : MonoBehaviour {

	public TextMesh textMesh;

	void Start ()
	{
		textMesh.text =  "Best Score\n" + GameController.BEST_SCORE ;
	}

}
