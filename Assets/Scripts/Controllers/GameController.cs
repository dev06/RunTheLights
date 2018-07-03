using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


	public GameObject Dummy;

	public static bool GameOver;

	void Awake()
	{
		Application.targetFrameRate = 60;

		Dummy.SetActive(false);

		GameOver = false;
	}
}
