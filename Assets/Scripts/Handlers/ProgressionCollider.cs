using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProgressionColliderType
{
	Intersection,
	Zone,
}
public class ProgressionCollider : MonoBehaviour {

	public ProgressionColliderType colliderType;

	void OnTriggerEnter(Collider col)
	{

		if (EventManager.OnProgressionColliderHit != null)
		{
			EventManager.OnProgressionColliderHit(colliderType);
		}
	}
}
