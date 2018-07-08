using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdditionTexts : MonoBehaviour {

	private int index;


	void Start()
	{
		float range = 100;
		foreach (Transform t in transform)
		{
			t.GetComponent<RectTransform>().anchoredPosition += new Vector2(Random.Range(-range, range), Random.Range(-6.31f, 5.31f));
			t.GetComponent<Text>().enabled = false;
		}
	}

	public void TriggerNextText(string text, Color? c = null)
	{

		Text t = transform.GetChild(index).GetComponent<Text>();
		t.text = text;
		t.color = c ?? new Color(1, 1, .5f, 1);
		t.enabled = true;
		transform.GetChild(index).GetComponent<Animation>().Play();
		index++;

		if (index > transform.childCount - 1)
		{
			index = 0;
		}
	}
}
