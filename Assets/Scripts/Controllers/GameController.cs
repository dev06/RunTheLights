using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


	public GameObject Dummy;

	public static bool GameOver;

	public static int CURRENT_ZONE;

	public static int POOLED_SECTION = 0;

	public static int ZONE_CHANGE_EVERY = 20;

	void Awake()
	{
		Application.targetFrameRate = 60;

		Dummy.SetActive(false);

		GameOver = false;

		POOLED_SECTION = 0;

		CURRENT_ZONE = 1;
	}
}
