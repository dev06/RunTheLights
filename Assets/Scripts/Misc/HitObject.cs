using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody))]
[RequireComponent (typeof(BoxCollider))]
public class HitObject : MonoBehaviour
{
	public  HitObjectType type;
	Rigidbody rb;
	private float upwardMultiplier = 1f;
	private float forwardMultiplier = 1.3f;
	void Start ()
	{

		rb = GetComponent<Rigidbody>();

		switch (type)
		{
			case HitObjectType.Light:
			{
				upwardMultiplier = 1f;
				forwardMultiplier = 1f;
				break;
			}
			case HitObjectType.Medium:
			{
				upwardMultiplier = 2f;
				forwardMultiplier = 5f;
				break;
			}
			case HitObjectType.Heavy:
			{
				upwardMultiplier = 1f;
				forwardMultiplier = 1.5f;
				break;
			}

		}

	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag != "Objects/Player") return;
		if (rb == null) return;

		float power = 7;
		rb.velocity += new Vector3(0, power, power * 1.2f);
		rb.AddTorque(new Vector3(Random.Range(-40f, 40f), Random.Range(-40f, 40f), Random.Range(-40f, 40f)));


		if (EventManager.OnHitObject != null)
		{
			EventManager.OnHitObject();
		}

	}
}

public enum HitObjectType
{
	Light,
	Medium,
	Heavy,
}
