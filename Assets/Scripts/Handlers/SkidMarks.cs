using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkidMarks : MonoBehaviour
{
	bool move;
	int trailIndex;
	Transform current;


	void OnEnable()
	{
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
	}
	void OnDisable()
	{

		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
	}

	void Start()
	{

	}
	void OnFingerDown()
	{
		move = false;
	}

	void OnFingerUp()
	{
		move = true;
		TriggerSkidMark();
	}

	void Update()
	{
		if (!move)
		{
			return;
		}
		current.transform.Translate(-Vector3.forward * Section.VELOCITY * Time.deltaTime, Space.World);

	}


	public void TriggerSkidMark()
	{
		current = transform.GetChild(trailIndex).transform;

		current.localPosition = Vector3.zero;

		for (int i = 0; i < transform.childCount; i++)
		{
			if (transform.GetChild(i).gameObject != current.gameObject)
			{
				transform.GetChild(i).GetComponent<Marker>().Toggle(false);
			}
		}

		for (int i = 0; i < current.childCount; i++)
		{
			current.GetComponent<Marker>().Toggle(true);
		}

		trailIndex++;

		if (trailIndex > transform.childCount - 1)
		{
			trailIndex = 0;
		}
	}
}
