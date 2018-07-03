using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SectionType
{
	Section_1,
	Section_2,
	Section_3,
}

public class Section : MonoBehaviour {


	public GameObject prefab;

	public static float VELOCITY = 0;

	public static readonly float MAX_VELOCITY = 15F;

	public Transform StartConnector;

	public Transform EndConnector;

	public SectionType type;

	public static bool EnalbedProps = true;

	private SectionContainer sectionContainer;

	private Section attachedSection;

	[HideInInspector]
	public Section connectedSection;

	[HideInInspector]
	public bool move = true;


	public GameObject Buildings;

	public ResetGameObject[] resetObjects;

	public void Init()
	{
		sectionContainer = FindObjectOfType<SectionContainer>();

		move = true;

		foreach (ResetGameObject rg in resetObjects)
		{
			rg.Initalize();
		}

		//Buildings.SetActive(EnalbedProps);
	}


	public void SetType(SectionType type)
	{
		this.type = type;
	}

	void Update()
	{
		if (!move) return;

		transform.Translate(-Vector3.forward * Time.deltaTime * VELOCITY, Space.World);

		if (attachedSection != null)
		{
			transform.position = attachedSection.EndConnector.position;
		}

		OutSide();
	}

	private void OutSide()
	{
		if (EndConnector.transform.position.z < -8f)
		{
			move = false;

			transform.gameObject.SetActive(false);

			sectionContainer.PoolSection(this);

			if (EventManager.OnSectionPool != null)
			{
				EventManager.OnSectionPool(type);
			}

			if (connectedSection != null)
			{
				connectedSection.attachedSection = null;

				connectedSection = null;
			}
		}
	}

	public void Move(Section s)
	{
		foreach (ResetGameObject rg in resetObjects)
		{
			rg.Reset();
		}

		this.attachedSection = s;

		attachedSection.connectedSection = this;

		transform.position = s.EndConnector.position;

		move = true;
	}


	public void Toggle(bool b)
	{
		foreach (Transform t in transform)
		{
			t.gameObject.SetActive(b);
		}

	}
}
