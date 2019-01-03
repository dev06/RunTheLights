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

	private Section parentSection;

	void OnTriggerEnter(Collider col)
	{
		if (colliderType == ProgressionColliderType.Stop)
		{
			Section.ACTIVE_SECTION = ParentSection;
		}
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

	public Section ParentSection
	{
		get
		{
			if (parentSection == null)
			{
				parentSection = transform.GetComponentInParent<Section>();
			}

			return parentSection;
		}
	}
}
