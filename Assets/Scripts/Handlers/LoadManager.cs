using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadManager : MonoBehaviour {

	public static LoadManager Instance;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			DestroyImmediate(gameObject);
		}

	}

	void Start()
	{
		LoadGame();
	}

	IEnumerator LoadNewScene(string sceneName) {

		yield return new WaitForEndOfFrame();
		AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);

		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone)
		{
			yield return null;
		}
	}

	public void LoadGame()
	{
		StartCoroutine(LoadNewScene("Main"));
	}
}
