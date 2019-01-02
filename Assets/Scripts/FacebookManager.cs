using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity.Mobile;
public class FacebookManager : MonoBehaviour {

	public static FacebookManager instance;
	private static bool isInit;
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

		Init();

	}

	public void Init()
	{
		if (!Facebook.Unity.FB.IsInitialized)
		{
			Facebook.Unity.FB.Init();
			isInit = true;
		}
		else
		{
			Facebook.Unity.FB.ActivateApp();
		}
	}


	public bool EventSent(string name)
	{
		if (!Facebook.Unity.FB.IsInitialized)
		{
			Facebook.Unity.FB.Init();
			return false;
		}
		Facebook.Unity.FB.LogAppEvent(name, 1);
		return true;
	}
}
