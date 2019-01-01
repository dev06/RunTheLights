using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class ResetGameObject : MonoBehaviour {

	Vector3 position;
	Vector3 scale;
	Quaternion rotation;
	Rigidbody rb;

	MeshRenderer mesh;
	BoxCollider collider;

	public bool isProp;
	private float spawningProb = 0f;

	public void Initalize()
	{
		position = transform.localPosition;
		scale = transform.localScale;
		rotation = transform.localRotation;

		mesh = GetComponent<MeshRenderer>();


		if (mesh == null)
		{
			mesh = transform.GetChild(0).GetComponent<MeshRenderer>();
		}

		collider = GetComponent<BoxCollider>();

		if (collider == null && transform.childCount > 0)
		{
			collider = transform.GetChild(0).GetComponent<BoxCollider>();
		}

		if (GetComponent<Rigidbody>() != null)
		{
			rb = GetComponent<Rigidbody>();
		}

		rb.isKinematic = isProp;

		Toggle(Random.Range(0f, 1f) < (!isProp ? spawningProb : .5f));

	}

	void Toggle(bool b)
	{
		mesh.enabled = b;
		if (collider != null)
		{
			collider.enabled = b;
		}
	}

	public void Reset()
	{
		transform.localPosition = position;
		transform.localScale = scale;
		transform.localRotation = rotation;
		rb.Sleep();
		rb.velocity = Vector3.zero;

		if (GameController.TutorialEnabled)
		{
			bool b = (TutorialHandler.Instance.CurrentStep == TutorialHandler.STEP_CLEAR) ? (Random.Range(0f, 1f) < .4f) : false;
			Toggle(b);
		}
		else
		{

			float f = (FuryHandler.Instance.FuryTime > .45f) ? .7f : 0f;
			Toggle(Random.Range(0f, 1f) < (!isProp ?  f : 1f));
		}
	}
}
