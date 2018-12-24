using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour {


	private MeshRenderer renderer;
	private BoxCollider boxCollider;

	void OnEnable()
	{

	}

	void OnDisable()
	{

	}

	void Start()
	{
		renderer = GetComponent<MeshRenderer>();
		boxCollider = GetComponent<BoxCollider>();
	}

	void Update ()
	{

	}

	public void Toggle(bool b)
	{
		if (renderer == null)
		{
			renderer = GetComponent<MeshRenderer>();
		}

		if (boxCollider == null) boxCollider = GetComponent<BoxCollider>();

		renderer.enabled = b;
		boxCollider.enabled =  b;
	}
}
