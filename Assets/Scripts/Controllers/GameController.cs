﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RabaGames;
using GameAnalyticsSDK;
public class GameController : MonoBehaviour {

	public static GameController Instance;

	public bool DeleteSave;

	public bool CanDie = true;

	public static readonly float MAX_CAR_SPEED = 50f;

	public static readonly float MAX_CAR_ACC = 50f;

	public static readonly float MAX_CAR_DEC = 50F;

	public static readonly float MAX_CAR_POWER = 10F;

	public static readonly int MAX_CARS_PER_STREAM = 5;

	public static readonly int MIN_CARS_PER_STREAM = 2;

	public static float STEER_INTENSITY;

	public static float MOVEMENT_MULTIPLIER;

	public static float CAR_STREAM_DELAY;

	public GameObject Dummy;

	public static bool GameOver;

	public static int CURRENT_ZONE;

	public static int POOLED_SECTION = 0;

	public static int ZONE_CHANGE_EVERY = 5;

	public static float DISTANCE_TRAVELED = 0;

	public static int SCORE = 0;

	public static int SESSION_SCORE = 0;

	public static float BEST_DISTANCE = 0;

	public static int BEST_SCORE = 0;

	public static int LIGHTS_RAN = 0;

	public static bool INSHOWCASE = false;

	public static int GAME_SCORE = 0;

	public static float GAME_DISTANCE = 0;

	public static int SELECTED_MODEL_INDEX = 0;

	public static int GAMES_PLAYED;

	public static bool APP_OPENED;

	public static int APP_OPENED_COUNT = 0;

	public static ShowcaseModel ActiveModel;

	public static bool TutorialEnabled;

	private int ShowRateDialogAtEvery = 5; //app starts

	private static bool sdk_init;

	public int LightsRanInLevel;

	void OnValidate()
	{
		if (DeleteSave)
		{
			PlayerPrefs.DeleteAll();
		}
	}



	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		Application.targetFrameRate = 60;

		if (!sdk_init)
		{
			GameAnalytics.Initialize();
			sdk_init = true;
		}

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

		INSHOWCASE = false;

		Section.VELOCITY = 0;

		Load();

		if (!APP_OPENED)
		{
			APP_OPENED_COUNT++;

			if (APP_OPENED_COUNT % ShowRateDialogAtEvery == 0 && BEST_SCORE >= 50)
			{
				if (Application.platform == RuntimePlatform.IPhonePlayer)
				{
					RateInsideAppiOS.DisplayReviewDialog();
				}

				APP_OPENED_COUNT = 0;
			}
			APP_OPENED = true;
		}

	}


	void OnApplicationQuit()
	{
		Save();
	}


	void OnEnable()
	{
		EventManager.OnZoneComplete += OnZoneComplete;

		EventManager.OnGameOver += OnGameOver;

		EventManager.OnGameStart += OnGameStart;

		EventManager.OnLevelComplete += OnLevelComplete;
	}

	void OnDisable()
	{
		EventManager.OnZoneComplete -= OnZoneComplete;

		EventManager.OnGameOver -= OnGameOver;

		EventManager.OnGameStart -= OnGameStart;

		EventManager.OnLevelComplete -= OnLevelComplete;
	}

	void OnZoneComplete()
	{
		CAR_STREAM_DELAY -= .2f;

		CAR_STREAM_DELAY = Mathf.Clamp(CAR_STREAM_DELAY, 1f , CAR_STREAM_DELAY);

		GameAnalytics.NewDesignEvent ("ZONE_PROGRESSION_" + CURRENT_ZONE, CURRENT_ZONE);
	}

	void OnLevelComplete()
	{
		if (TutorialEnabled)
		{
			TutorialEnabled = false;
		}

		// ZONE_CHANGE_EVERY++;

		// ZONE_CHANGE_EVERY = Mathf.Clamp(ZONE_CHANGE_EVERY, 5, 30);

		PlayerPrefs.SetInt("ZONE_CHANGE_EVERY", ZONE_CHANGE_EVERY);
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
		SESSION_SCORE += addition;

		if (EventManager.OnUpdateUI != null)
		{
			EventManager.OnUpdateUI();
		}
	}

	void OnGameStart()
	{
		GAMES_PLAYED++;
		GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "game");
	}


	void OnGameOver()
	{
		GameAnalytics.NewProgressionEvent (GAProgressionStatus.Complete, "game", GAME_SCORE); // with score
		Haptic.VibrateHandheld();
		Save();
		StopCoroutine("IOnDeath");
		StartCoroutine("IOnDeath");
		SESSION_SCORE = 0;
	}


	IEnumerator IOnDeath()
	{
		yield return new WaitForSeconds(2.5f);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

	public void Save()
	{


		if (SESSION_SCORE > BEST_SCORE)
		{
			BEST_SCORE = SESSION_SCORE;
		}


		PlayerPrefs.SetInt("ZONE_CHANGE_EVERY", ZONE_CHANGE_EVERY);

		PlayerPrefs.SetInt("LEVEL", LevelController.LEVEL);

		PlayerPrefs.SetInt("SESSION_SCORE", SESSION_SCORE);

		PlayerPrefs.SetInt("BEST_SCORE", BEST_SCORE);

		PlayerPrefs.SetInt("SELECTED_MODEL_INDEX", SELECTED_MODEL_INDEX);

		PlayerPrefs.SetInt("GAMES_PLAYED", GAMES_PLAYED);

		PlayerPrefs.SetInt("LIGHTS_RAN", LIGHTS_RAN);

		PlayerPrefs.SetInt("APP_OPENED_COUNT", APP_OPENED_COUNT);




	}

	void Load()
	{

		LevelController.LEVEL =  PlayerPrefs.HasKey("LEVEL") ? PlayerPrefs.GetInt("LEVEL") : 0;

		TutorialEnabled = LevelController.LEVEL == 0;

		ZONE_CHANGE_EVERY =  TutorialEnabled ? 8 : (PlayerPrefs.HasKey("ZONE_CHANGE_EVERY") ? PlayerPrefs.GetInt("ZONE_CHANGE_EVERY") + 1 : 8);

		ZONE_CHANGE_EVERY = Mathf.Clamp(ZONE_CHANGE_EVERY, 8, 15);

		BEST_SCORE = PlayerPrefs.GetInt("BEST_SCORE");

		SELECTED_MODEL_INDEX = PlayerPrefs.GetInt("SELECTED_MODEL_INDEX");

		GAMES_PLAYED = PlayerPrefs.GetInt("GAMES_PLAYED");

		Haptic.Enabled = PlayerPrefs.HasKey("Vibration") ? bool.Parse(PlayerPrefs.GetString("Vibration")) : true;

		LIGHTS_RAN = PlayerPrefs.HasKey("LIGHTS_RAN") ? PlayerPrefs.GetInt("LIGHTS_RAN") : 0;

		APP_OPENED_COUNT = PlayerPrefs.GetInt("APP_OPENED_COUNT");

		CAR_STREAM_DELAY = 1.5F;
	}

	public void ToggleVibration(bool b)
	{
		Haptic.Enabled = b;

		PlayerPrefs.SetString("Vibration", Haptic.Enabled.ToString());

		Haptic.Vibrate(HapticIntensity.Medium);
	}

}
