using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SectionType
{
	None,
	Section_0,
	Section_1,
	Section_2,
	Section_3,
	Section_4,
	Section_5,
	Section_6,
	Section_7,
	Section_8,
	Section_9,
	Section_10, //jungle
	Section_11, //mountain
	Section_12, //mountain
	Section_13, //mountain
	Section_14,
	Section_15,
	Section_16,
}

public enum SectionCategory
{
	None,
	Building,
	Neighborhood,
	Jungle,
	Construction,
}

public class Section : MonoBehaviour {

	public int ZoneID = -1;

	public SectionCategory category;

	public GameObject prefab;

	public static float VELOCITY = 0;

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

	public Transform hitObjects;

	public Transform gears;

	private List<ResetGameObject> resetObjects;

	private Vector3 targetConnectorPosition;

	private bool canPoolSection = true;


	void OnEnable()
	{
		EventManager.OnLevelComplete += OnLevelComplete;

		EventManager.OnTutorialStep += OnTutorialStep;
	}

	void OnDisable()
	{
		EventManager.OnLevelComplete -= OnLevelComplete;

		EventManager.OnTutorialStep -= OnTutorialStep;
	}

	public void Init()
	{
		sectionContainer = FindObjectOfType<SectionContainer>();

		move = true;

		FillHitObjects();

		targetConnectorPosition = transform.position;

		ToggleGears(false);
	}

	private void FillHitObjects()
	{
		if (hitObjects == null) { return; }

		resetObjects = new List<ResetGameObject>();

		for (int i = 0; i < hitObjects.childCount; i++)
		{
			resetObjects.Add(hitObjects.GetChild(i).GetComponent<ResetGameObject>());
		}

		foreach (ResetGameObject rg in resetObjects)
		{
			if (rg != null)
			{
				rg.Initalize();
			}
		}


	}


	public void SetType(SectionType type)
	{
		this.type = type;
	}

	public void SetCategory(SectionCategory category)
	{
		this.category = category;
	}

	void Update()
	{
		if (!move) { return; }

		transform.Translate(-Vector3.forward * Time.deltaTime * VELOCITY, Space.World);

		if (attachedSection != null)
		{
			targetConnectorPosition = new Vector3(attachedSection.EndConnector.position.x, 0, attachedSection.EndConnector.position.z);
			transform.position = Vector3.Lerp(transform.position, targetConnectorPosition, Time.deltaTime * 10f);
		}

		OutSide();
	}

	private void OutSide()
	{
		if (canPoolSection == false) { return; }

		if (EndConnector.transform.position.z < -10f)
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
		if (resetObjects != null)
		{
			if (resetObjects.Count > 0)
			{
				foreach (ResetGameObject rg in resetObjects)
				{
					rg.Reset();
				}
			}
		}

		if (GameController.TutorialEnabled == false)
		{
			ToggleGears(true);
		}
		else
		{
			ToggleGears(TutorialHandler.Instance.CurrentStep == TutorialHandler.STEP_GEAR);
		}


		this.attachedSection = s;

		attachedSection.connectedSection = this;

		targetConnectorPosition = s.EndConnector.position;

		transform.position = s.EndConnector.position + new Vector3(0, -50, 0);

		// transform.position = s.EndConnector.position;

		move = true;
	}


	public void Toggle(bool b)
	{
		foreach (Transform t in transform)
		{
			t.gameObject.SetActive(b);
		}
	}


	private void OnLevelComplete()
	{
		canPoolSection = false;
	}

	void OnTutorialStep(int step)
	{

	}

	private void ToggleGears(bool b)
	{
		if (gears == null)
		{

			return;
		}

		foreach (Transform t in gears)
		{
			t.GetComponent<Gear>().Toggle(b);
		}
	}
}
