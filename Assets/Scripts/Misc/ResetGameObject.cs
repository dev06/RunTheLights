using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameObject : MonoBehaviour {

	Vector3 position;
	Vector3 scale;
	Quaternion rotation;
	Rigidbody rb;

	public void Initalize()
	{
		position = transform.localPosition;
		scale = transform.localScale;
		rotation = transform.localRotation;

		if (GetComponent<Rigidbody>() != null)
		{
			rb = GetComponent<Rigidbody>();
		}
	}

	public void Reset()
	{
		transform.localPosition = position;
		transform.localScale = scale;
		transform.localRotation = rotation;
		rb.Sleep();
		rb.velocity = Vector3.zero;
	}
}
