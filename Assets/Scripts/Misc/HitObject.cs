using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class HitObject : MonoBehaviour {

	Rigidbody rb;
	void Start () {

		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag != "Objects/Player") return;
		if (rb == null) return;

		float min = Mathf.Clamp((Section.VELOCITY / Section.MAX_VELOCITY), .7f, 1f);
		rb.velocity += new Vector3(0, 10f, 10f) * (min) / rb.mass ;
		rb.AddTorque(new Vector3(Random.Range(-40f, 40f), Random.Range(-40f, 40f), Random.Range(-40f, 40f)));
	}
}
