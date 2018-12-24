using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ProgressionColliderType
{
	Intersection,
	Zone,
	Stop,
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

	void OnTriggerExit(Collider col)
	{
		if (EventManager.OnProgressionColliderExit != null)
		{
			EventManager.OnProgressionColliderExit(colliderType);
		}
	}
}
