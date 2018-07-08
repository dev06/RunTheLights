using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static readonly int MAX_CARS_PER_STREAM = 5;

	public static readonly int MIN_CARS_PER_STREAM = 2;

	public static int MAX_VELOCITY;

	public GameObject Dummy;

	public static bool GameOver;

	public static int CURRENT_ZONE;

	public static int POOLED_SECTION = 0;

	public static int ZONE_CHANGE_EVERY = 10;

	public static float DISTANCE_TRAVELED = 0;

	public static int SCORE = 0;

	public static int ACTIVE_CARS = 2;



	void Awake()
	{
		Application.targetFrameRate = 60;

		Dummy.SetActive(false);

		GameOver = false;

		POOLED_SECTION = 0;

		CURRENT_ZONE = 1;

		DISTANCE_TRAVELED = 0;

		SCORE = 0;

		ACTIVE_CARS = MIN_CARS_PER_STREAM;

		MAX_VELOCITY = 20;
	}


	void OnEnable()
	{
		EventManager.OnZoneComplete += OnZoneComplete;

		EventManager.OnGameOver += OnGameOver;
	}

	void OnDisable()
	{
		EventManager.OnZoneComplete -= OnZoneComplete;

		EventManager.OnGameOver -= OnGameOver;
	}

	void OnZoneComplete()
	{
		ACTIVE_CARS++;

		MAX_VELOCITY += 1;

		ACTIVE_CARS = Mathf.Clamp(ACTIVE_CARS, MIN_CARS_PER_STREAM, MAX_CARS_PER_STREAM);
	}

	void Start()
	{

		UserInterface[] ui = FindObjectsOfType<UserInterface>();

		foreach (UserInterface u in ui)
		{
			u.Init();
		}
	}

	public static void SetScore(int addition)
	{
		SCORE += addition;

		if (EventManager.OnUpdateUI != null)
		{
			EventManager.OnUpdateUI();
		}
	}


	void OnGameOver()
	{
		Haptic.VibrateHandheld();
		StopCoroutine("IOnDeath");
		StartCoroutine("IOnDeath");
	}


	IEnumerator IOnDeath()
	{
		yield return new WaitForSeconds(2.5f);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

}
