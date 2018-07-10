using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public bool DeleteSave;

	public static readonly int MAX_CARS_PER_STREAM = 5;

	public static readonly int MIN_CARS_PER_STREAM = 2;

	public static float MAX_VELOCITY;

	public static float STEER_INTENSITY;

	public static float MOVEMENT_MULTIPLIER;

	public GameObject Dummy;

	public static bool GameOver;

	public static int CURRENT_ZONE;

	public static int POOLED_SECTION = 0;

	public static int ZONE_CHANGE_EVERY = 10;

	public static float DISTANCE_TRAVELED = 0;

	public static int SCORE = 0;

	public static float BEST_DISTANCE = 0;

	public static int BEST_SCORE = 0;

	public static int ACTIVE_CARS = 2;

	public static bool INSHOWCASE = false;

	public static int GAME_SCORE = 0;

	public static float GAME_DISTANCE = 0;

	public static int SELECTED_MODEL_INDEX = 0;

	public static int GAMES_PLAYED;

	void OnValidate()
	{
		if (DeleteSave)
		{
			PlayerPrefs.DeleteAll();
		}
	}



	void Awake()
	{
		Application.targetFrameRate = 60;

		Dummy.SetActive(false);

		GameOver = false;

		POOLED_SECTION = 0;

		CURRENT_ZONE = 1;

		DISTANCE_TRAVELED = 0;

		SCORE = 0;

		GAME_SCORE = 0;

		GAME_DISTANCE = 0;

		GAMES_PLAYED = 0;

		SELECTED_MODEL_INDEX = 0;

		ACTIVE_CARS = MIN_CARS_PER_STREAM;

		MAX_VELOCITY = 20F;


		INSHOWCASE = false;

		Load();
	}


	void OnEnable()
	{
		EventManager.OnZoneComplete += OnZoneComplete;

		EventManager.OnGameOver += OnGameOver;

		EventManager.OnGameStart += OnGameStart;
	}

	void OnDisable()
	{
		EventManager.OnZoneComplete -= OnZoneComplete;

		EventManager.OnGameOver -= OnGameOver;

		EventManager.OnGameStart -= OnGameStart;
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
		GAME_SCORE += addition;

		if (EventManager.OnUpdateUI != null)
		{
			EventManager.OnUpdateUI();
		}
	}

	void OnGameStart()
	{
		GAMES_PLAYED++;
	}


	void OnGameOver()
	{
		Haptic.VibrateHandheld();
		Save();
		StopCoroutine("IOnDeath");
		StartCoroutine("IOnDeath");
	}


	IEnumerator IOnDeath()
	{
		yield return new WaitForSeconds(2.5f);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

	void Save()
	{
		SCORE = GAME_SCORE;

		DISTANCE_TRAVELED = GAME_DISTANCE;

		if (SCORE > BEST_SCORE)
		{
			BEST_SCORE = SCORE;
		}

		if (DISTANCE_TRAVELED > BEST_DISTANCE)
		{
			BEST_DISTANCE = DISTANCE_TRAVELED;
		}

		PlayerPrefs.SetInt("SCORE", SCORE);
		PlayerPrefs.SetFloat("DISTANCE_TRAVELED", DISTANCE_TRAVELED);

		PlayerPrefs.SetInt("BEST_SCORE", BEST_SCORE);
		PlayerPrefs.SetFloat("BEST_DISTANCE", BEST_DISTANCE);

		PlayerPrefs.SetInt("SELECTED_MODEL_INDEX", SELECTED_MODEL_INDEX);

		PlayerPrefs.SetInt("GAMES_PLAYED", GAMES_PLAYED);




	}

	void Load()
	{
		SCORE = PlayerPrefs.GetInt("SCORE");

		BEST_SCORE = PlayerPrefs.GetInt("BEST_SCORE");

		DISTANCE_TRAVELED = PlayerPrefs.GetFloat("DISTANCE_TRAVELED");

		BEST_DISTANCE = PlayerPrefs.GetFloat("BEST_DISTANCE");

		SELECTED_MODEL_INDEX = PlayerPrefs.GetInt("SELECTED_MODEL_INDEX");

		GAMES_PLAYED = PlayerPrefs.GetInt("GAMES_PLAYED");
	}

}
