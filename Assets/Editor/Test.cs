using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	[MenuItem ("GameObject/Set Pivot")]
	public static void T(Section prefabInstance)
	{
		if (PrefabUtility.RevertPrefabInstance(prefabInstance.prefab))
		{
			Debug.Log("Reseted Properly");
		}
		else
		{
			Debug.Log("Not");
		}

	}
}
