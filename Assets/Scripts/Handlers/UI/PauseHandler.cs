using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PauseHandler: UserInterface
{
	private Animation animation;

	void Start()
	{
		animation = GetComponent<Animation>();
	}

	void OnEnable()
	{
		EventManager.OnPauseStatus += OnPauseStatus;

		EventManager.OnButtonClick += OnButtonClick;
	}

	void OnDisable()
	{
		EventManager.OnPauseStatus -= OnPauseStatus;

		EventManager.OnButtonClick -= OnButtonClick;
	}

	void OnButtonClick(ButtonID id)
	{
		switch (id)
		{
			case ButtonID.Pause:
			{
				if (EventManager.OnPauseStatus != null)
				{
					EventManager.OnPauseStatus(true);
				}
				break;
			}

			case ButtonID.Resume:
			{
				if (EventManager.OnPauseStatus != null)
				{
					EventManager.OnPauseStatus(false);
				}
				break;
			}

		}
	}

	void OnPauseStatus(bool b)
	{
		if (b)
		{
			animation.Play();
			StopCoroutine("IWait");
			StartCoroutine("IWait");
		}
		else
		{
			Time.timeScale = 1;
		}

		Toggle(b);
	}

	IEnumerator IWait()
	{
		while (animation.isPlaying)
		{
			yield return null;
		}
		Time.timeScale = 0;
	}
}