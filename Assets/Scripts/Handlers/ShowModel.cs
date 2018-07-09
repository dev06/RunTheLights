using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowModel : MonoBehaviour {

	Quaternion defaultRotation, targetRotation;
	Vector3 defaultScale, targetScale;
	float rotationSpeed;
	bool selected;


	void Start ()
	{
		defaultRotation = transform.localRotation;
		defaultScale = transform.localScale;

		targetRotation = defaultRotation;
		targetScale = defaultScale;
	}

	void Update ()
	{
		if (selected)
		{
			transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed, Space.World);
		}
		else
		{
			transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * 10f);
		}

		transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * 10f);
	}

	public void ResetTransform()
	{
		targetScale = defaultScale;
		targetRotation = defaultRotation;
		rotationSpeed = 0;
		selected = false;
	}

	public void Select()
	{
		targetScale = defaultScale * 1.5f;
		rotationSpeed = 50f;
		selected = true;
	}

}
