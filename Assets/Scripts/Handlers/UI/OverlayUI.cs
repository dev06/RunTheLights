using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverlayUI : MonoBehaviour {

	public Animation fadeOverlay;

	void Start()
	{
		fadeOverlay.transform.GetComponent<Image>().color = new Color(0f, 0f, 0f, 1f);
	}

	void OnSceneLoaded (Scene scene, LoadSceneMode mode)
	{
		StopCoroutine("ITest");
		StartCoroutine("ITest");
	}
	IEnumerator ITest()
	{
		fadeOverlay[fadeOverlay.clip.name].speed = 1;
		fadeOverlay[fadeOverlay.clip.name].time = 0;

		yield return new WaitForEndOfFrame();

		fadeOverlay.Play(fadeOverlay.clip.name);

	}

	void OnEnable()
	{
		EventManager.OnRestartGame += OnRestartGame;
		SceneManager.sceneLoaded += OnSceneLoaded;
	}
	void OnDisable()
	{
		EventManager.OnRestartGame -= OnRestartGame;
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	void OnRestartGame()
	{
		StopCoroutine("IRestartGame");
		StartCoroutine("IRestartGame");
	}

	IEnumerator IRestartGame()
	{
		fadeOverlay[fadeOverlay.clip.name].speed = -1;
		fadeOverlay[fadeOverlay.clip.name].time = fadeOverlay[fadeOverlay.clip.name].length;
		fadeOverlay.Play(fadeOverlay.clip.name);
		while (fadeOverlay.isPlaying)
		{
			yield return null;
		}

		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}




}
