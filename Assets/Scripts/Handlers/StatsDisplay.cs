using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsDisplay : MonoBehaviour {

	public TextMesh textMesh;


	void OnEnable()
	{
		EventManager.OnMapSelected += OnMapSelected;
	}
	void OnDisable()
	{
		EventManager.OnMapSelected -= OnMapSelected;
	}

	void OnMapSelected(Map m)
	{
		textMesh.text =  "Best Score\n" + m.mapStats.Score;
	}
	void Start ()
	{
		textMesh.text =  "Best Score\n" + MapSelectUI.SelectedMap.mapStats.Score;
	}

}
