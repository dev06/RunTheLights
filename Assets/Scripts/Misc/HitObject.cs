using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(BoxCollider))]
public class HitObject : MonoBehaviour {

	Rigidbody rb;
	public float upwardMultiplier = 1f;
	public float forwardMultiplier = 1f;
	void Start ()
	{

		rb = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag != "Objects/Player") return;
		if (rb == null) return;

		float min = Mathf.Clamp((Section.VELOCITY / GameController.MAX_VELOCITY), .7f, 1f);
		rb.velocity += new Vector3(0, 10f * upwardMultiplier, 10f * forwardMultiplier) * (min) / rb.mass ;
		rb.AddTorque(new Vector3(Random.Range(-40f, 40f), Random.Range(-40f, 40f), Random.Range(-40f, 40f)));


		if (EventManager.OnHitObject != null)
		{
			EventManager.OnHitObject();
		}
	}
}
