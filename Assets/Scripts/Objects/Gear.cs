using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour {


	private MeshRenderer renderer;
	private BoxCollider boxCollider;
	private bool canMoveUp;
	private Vector3 defaultPosition;
	private Vector3 defaultScale;



	void Start()
	{
		renderer = GetComponent<MeshRenderer>();
		boxCollider = GetComponent<BoxCollider>();

		defaultPosition = transform.localPosition;
		defaultScale = transform.localScale;
	}

	void Update ()
	{
		if (!canMoveUp) return;

		transform.Translate(Vector3.up * Time.deltaTime * 20f, Space.World);
		transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, Time.deltaTime * 3f);
	}

	public void Animate()
	{
		canMoveUp = true;
	}

	public void Toggle(bool b)
	{
		if (renderer == null)
		{
			renderer = GetComponent<MeshRenderer>();
		}

		if (boxCollider == null) boxCollider = GetComponent<BoxCollider>();

		canMoveUp = false;

		if (defaultPosition == Vector3.zero)
		{
			defaultPosition = transform.localPosition;
		}

		if (defaultScale == Vector3.zero)
		{
			defaultScale = transform.localScale;
		}


		transform.localPosition = defaultPosition;
		transform.localScale = defaultScale;

		renderer.enabled = b;
		boxCollider.enabled =  b;
	}
}
