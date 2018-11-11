using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public static LevelController Instance;

	public static int LEVEL = 2;

	public static float LOAD_NEXT_LEVEL_DELAY = 4f; // second delay for loading level;

	void Awake ()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	void OnEnable()
	{
		EventManager.OnLevelComplete += OnLevelComplete;
	}
	void OnDisable()
	{
		EventManager.OnLevelComplete -= OnLevelComplete;
	}

	private void OnLevelComplete()
	{
		LEVEL++;

		GameController.Instance.Save();

		StopCoroutine("ILoadNextLevel");

		StartCoroutine("ILoadNextLevel");
	}


	private IEnumerator ILoadNextLevel()
	{
		yield return new WaitForSeconds(LOAD_NEXT_LEVEL_DELAY);

		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

	public SectionCategory GetSectionCategoryFromLevel()
	{
		SectionCategory cat = SectionCategory.None;
		cat = (SectionCategory)((LEVEL % 4) + 1);
		return cat;
	}


}
