using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
	private TrailRenderer[] trails;


	void Start()
	{
		trails = GetComponentsInChildren<TrailRenderer>();
	}

	public void Toggle(bool b)
	{
		for (int i = 0; i < trails.Length; i++)
		{
			if (b)
				trails[i].GetComponent<TrailRenderer>().Clear();
			trails[i].GetComponent<TrailRenderer>().enabled = b;
		}
	}
}