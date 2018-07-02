﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	Vector3 targetPosition;

	public bool move;

	int direction;

	public float CarSpeed = 100f;

	void Start ()
	{
		CarSpeed = 10f;
	}

	// Update is called once per frame
	void Update ()
	{
		if (!move) return;

		transform.Translate(direction * Vector3.right * Time.deltaTime * CarSpeed, Space.World);

	}

	public void Move(Vector3 startingPos, Vector3 target, int direction)
	{
		move = true;
		transform.position = startingPos + new Vector3(0, 0, Random.Range(-.2f, .2f));
		this.direction = direction;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Trigger/Carpool")
		{
			move = false;
			transform.gameObject.SetActive(false);
		}
	}

	public void SetMove(bool b)
	{
		move = b;
	}
}
