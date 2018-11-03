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
	private float spawningProb = .2f;

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


		Toggle(Random.Range(0f, 1f) < (!isProp ? (spawningProb + (FuryHandler.InFury ? .5f : 0f)) : .5f));
	}
}
