using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppResources : MonoBehaviour {


	public static GameObject Section_1 = Resources.Load("Prefabs/Section_Prefabs/Section") as GameObject;
	public static GameObject Section_2 = Resources.Load("Prefabs/Section_Prefabs/Section_2") as GameObject;
	public static GameObject Section_3 = Resources.Load("Prefabs/Section_Prefabs/Section_3") as GameObject;



	public static GameObject Car = Resources.Load("Prefabs/Car_Prefabs/Car") as GameObject;
	public static GameObject Car_2 = Resources.Load("Prefabs/Car_Prefabs/Car_2") as GameObject;
	public static GameObject Car_3 = Resources.Load("Prefabs/Car_Prefabs/Car_3") as GameObject;
	public static GameObject Car_4 = Resources.Load("Prefabs/Car_Prefabs/Car_4") as GameObject;
	public static GameObject Car_5 = Resources.Load("Prefabs/Car_Prefabs/Car_5") as GameObject;

	public static GameObject[] Vehicles =
	{
		Car,
		Car_2,
		Car_3,
		Car_4,
		Car_5,
	};

}
