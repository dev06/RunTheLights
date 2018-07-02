﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppResources : MonoBehaviour {


	public static GameObject Section_1 = Resources.Load("Prefabs/Section") as GameObject;
	public static GameObject Section_2 = Resources.Load("Prefabs/Section_2") as GameObject;
	public static GameObject Section_3 = Resources.Load("Prefabs/Section_3") as GameObject;



	public static GameObject Car = Resources.Load("Prefabs/Car") as GameObject;
	public static GameObject Car_2 = Resources.Load("Prefabs/Car_2") as GameObject;
	public static GameObject Car_3 = Resources.Load("Prefabs/Car_3") as GameObject;

	public static GameObject[] Vehicles =
	{
		Car,
		Car_2,
		Car_3,
	};

}
