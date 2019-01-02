using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppResources : MonoBehaviour {


	public static GameObject Section_0 = Resources.Load("Prefabs/Section_Prefabs/Section_0") as GameObject;
	public static GameObject Section_1 = Resources.Load("Prefabs/Section_Prefabs/Section") as GameObject;
	public static GameObject Section_2 = Resources.Load("Prefabs/Section_Prefabs/Section_2") as GameObject;
	public static GameObject Section_3 = Resources.Load("Prefabs/Section_Prefabs/Section_3") as GameObject;
	public static GameObject Section_4 = Resources.Load("Prefabs/Section_Prefabs/Section_4") as GameObject;
	public static GameObject Section_5 = Resources.Load("Prefabs/Section_Prefabs/Section_5") as GameObject;
	public static GameObject Section_6 = Resources.Load("Prefabs/Section_Prefabs/Section_6") as GameObject;
	public static GameObject Section_7 = Resources.Load("Prefabs/Section_Prefabs/Section_7") as GameObject;
	public static GameObject Section_8 = Resources.Load("Prefabs/Section_Prefabs/Section_8") as GameObject;
	public static GameObject Section_9 = Resources.Load("Prefabs/Section_Prefabs/Section_9") as GameObject;
	public static GameObject Section_10 = Resources.Load("Prefabs/Section_Prefabs/Section_10") as GameObject;
	public static GameObject Section_11 = Resources.Load("Prefabs/Section_Prefabs/Section_11") as GameObject;
	public static GameObject Section_12 = Resources.Load("Prefabs/Section_Prefabs/Section_12") as GameObject;
	public static GameObject Section_13 = Resources.Load("Prefabs/Section_Prefabs/Section_13") as GameObject;
	public static GameObject Section_14 = Resources.Load("Prefabs/Section_Prefabs/Section_14") as GameObject;
	public static GameObject Section_15 = Resources.Load("Prefabs/Section_Prefabs/Section_15") as GameObject;
	public static GameObject Section_16 = Resources.Load("Prefabs/Section_Prefabs/Section_16") as GameObject;






	public static GameObject car_1_1 =  Resources.Load("Prefabs/Car_Prefabs/car_1/car_1_1") as GameObject;
	public static GameObject car_1_2 =  Resources.Load("Prefabs/Car_Prefabs/car_1/car_1_2") as GameObject;
	public static GameObject car_1_3 =  Resources.Load("Prefabs/Car_Prefabs/car_1/car_1_3") as GameObject;


	public static GameObject car_2_1 =  Resources.Load("Prefabs/Car_Prefabs/car_2/car_2_1") as GameObject;
	public static GameObject car_2_2 =  Resources.Load("Prefabs/Car_Prefabs/car_2/car_2_2") as GameObject;

	public static GameObject car_3_1 =  Resources.Load("Prefabs/Car_Prefabs/car_3/car_3_1") as GameObject;

	public static GameObject car_5_1 =  Resources.Load("Prefabs/Car_Prefabs/car_5/car_5_1") as GameObject;
	public static GameObject car_5_2 =  Resources.Load("Prefabs/Car_Prefabs/car_5/car_5_2") as GameObject;

	public static GameObject car_6_1 =  Resources.Load("Prefabs/Car_Prefabs/car_6/car_6_1") as GameObject;
	public static GameObject car_6_2 =  Resources.Load("Prefabs/Car_Prefabs/car_6/car_6_2") as GameObject;
	public static GameObject car_6_3 =  Resources.Load("Prefabs/Car_Prefabs/car_6/car_6_3") as GameObject;



	public static GameObject[] ZONE_1_CARS =
	{
		car_1_1,
		car_1_2,
		car_1_3,

		car_2_2,

		car_3_1,

		// car_5_1,
		// car_5_2,
		// car_6_1,

		// car_6_3,
	};

	public static GameObject[] ZONE_2_CARS =
	{
		// car_1_1,
		// car_1_2,
		// car_1_3,

		//car_3_1,

		car_2_1,
		car_2_2,

		car_6_1,
		car_6_2,
		car_6_3,

	};

	public static GameObject[] ZONE_3_CARS =
	{
		car_1_1,
		//	car_1_2,
		//	car_1_3,

		car_2_1,
		//	car_2_2,

		car_6_1,
		//car_6_2,
		car_6_3,

		car_5_1,
		car_5_2,

	};


	public static GameObject[][] ZONE_CARS =
	{
		ZONE_1_CARS,
		ZONE_2_CARS,
		ZONE_3_CARS,
	};

}
