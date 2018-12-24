
using UnityEngine;
using UnityEditor;
using System.Collections;

class LoadFirstScene : EditorWindow
{

	[MenuItem("Play/PlayMe _%h")]
	public static void RunMainScene()
	{
		EditorApplication.OpenScene("Assets/Load.unity");
		EditorApplication.isPlaying = true;
	}
}
