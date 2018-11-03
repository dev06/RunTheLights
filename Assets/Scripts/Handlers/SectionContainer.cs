using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionContainer : MonoBehaviour {

	public static List<Section> sections = new List<Section>();

	public static List<Section> generated = new List<Section>();

	public Transform reservedTransform;

	public Section lastReservedSection;

	private SectionType lastType = SectionType.None;

	private int defaultActive = 6;


	[HideInInspector]
	public int zoneIndex = 1;


	void OnEnable()
	{
		EventManager.OnProgressionColliderHit += OnProgressionColliderHit;
	}

	void OnDisable()
	{
		EventManager.OnProgressionColliderHit -= OnProgressionColliderHit;
	}

	void Awake()
	{
		sections.Clear();
	}

	void Start ()
	{
		SpawnSection();
	}


	public void SpawnSection()
	{

		CreateSection(SectionType.Section_0);

		// for (int i = 0; i < 4; i++)
		// {
		// 	CreateSection(SectionType.Section_1);
		// }
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_2);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_3);
		}
		// for (int i = 0; i < 4; i++)
		// {
		// 	CreateSection(SectionType.Section_4);
		// }
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_5);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_6);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_7);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_8);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_9);
		}

		CreateSection(SectionType.Section_10);

		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_11);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_12);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_13);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_14);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_15);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_16);
		}
		RepositionSections();

	}

	private void RepositionSections()
	{

		List<Section> queue = new List<Section>();

		int r = Random.Range(0, reservedTransform.childCount);

		int index = 0;

		Section to = GetSectionFromReservedByType(SectionType.Section_0);

		queue.Add(to);

		SectionCategory targetCategory = LevelController.Instance.GetSectionCategoryFromLevel();

		SectionType lastChosenType = to.type;

		int breakCount = 0;

		bool canBypass = false;

		do
		{

			breakCount++;

			if (breakCount > 100)
			{
				Debug.Log("Break");
				break;
			}

			r = Random.Range(0, reservedTransform.childCount);

			to = reservedTransform.GetChild(r).GetComponent<Section>();

			if (to.category != targetCategory) { continue; }

			if (!queue.Contains(to) && lastChosenType != to.type)
			{

				queue.Add(to);

				index++;

				lastChosenType = to.type;

			}

		}
		while (queue.Count < 4);


		for (int i = 0; i < queue.Count; i++)
		{

			queue[i].transform.SetParent(transform);
			queue[i].transform.gameObject.SetActive(true);


			Vector3 position = new Vector3(0, 0, -5);

			if (i > 0)
			{
				position = queue[i - 1].EndConnector.position;
			}

			queue[i].transform.position = position;

			sections.Add(queue[i]);


		}

	}


	public void CreateSection(SectionType type)
	{

		GameObject prefab = DeterminePrefab(type);

		GameObject clone = Instantiate(prefab) as GameObject;

		clone.transform.SetParent(reservedTransform);

		clone.name = prefab.name;

		clone.SetActive(false);

		Section sec = clone.GetComponent<Section>();

		sec.prefab = clone;

		generated.Add(clone.GetComponent<Section>());

		sec.SetType(type);

		sec.Init();

	}

	private GameObject DeterminePrefab(SectionType type)
	{
		switch (type)
		{
			case SectionType.Section_0: return AppResources.Section_0;
			case SectionType.Section_1: return AppResources.Section_1;
			case SectionType.Section_2: return AppResources.Section_2;
			case SectionType.Section_3: return AppResources.Section_3;
			case SectionType.Section_4: return AppResources.Section_4;
			case SectionType.Section_5: return AppResources.Section_5;
			case SectionType.Section_7: return AppResources.Section_7;
			case SectionType.Section_6: return AppResources.Section_6;
			case SectionType.Section_8: return AppResources.Section_8;
			case SectionType.Section_9: return AppResources.Section_9;
			case SectionType.Section_10: return AppResources.Section_10;
			case SectionType.Section_11: return AppResources.Section_11;
			case SectionType.Section_12: return AppResources.Section_12;
			case SectionType.Section_13: return AppResources.Section_13;
			case SectionType.Section_14: return AppResources.Section_14;
			case SectionType.Section_15: return AppResources.Section_15;
			case SectionType.Section_16: return AppResources.Section_16;

			default: return AppResources.Section_1;
		}
	}

	private int sectionCount;

	int lastChosenIndex;

	private Section nextSection = null;

	public void PoolSection(Section section)
	{

		GameController.POOLED_SECTION++;

		section.transform.gameObject.SetActive(false);

		if (section.type != SectionType.Section_0)
		{
			section.transform.SetParent(reservedTransform);
		}
		else
		{
			section.transform.SetParent(null);
		}

	}

	//Called when player hits the finish line, marks begin of level end process.
	private void OnProgressionColliderHit(ProgressionColliderType type)
	{
		if (type == ProgressionColliderType.Zone)
		{
			if (EventManager.OnLevelComplete != null)
			{
				EventManager.OnLevelComplete();
			}
		}

		if (type == ProgressionColliderType.Intersection)
		{
			nextSection = GetSectionByLevel();

			if (GameController.Instance.LightsRanInLevel > GameController.ZONE_CHANGE_EVERY - 3)
			{
				nextSection = GetSection(SectionType.Section_10);
			}

			Section s = nextSection;

			//	s = GetSection(SectionType.Section_15);

			s.transform.SetParent(transform);

			s.transform.gameObject.SetActive(true);

			lastReservedSection = lastReservedSection == null ? sections[sections.Count - 1] : lastReservedSection;

			s.Move(lastReservedSection);

			lastReservedSection = s;
		}
	}


	public Section GetSectionByLevel()
	{
		int r = Random.Range(0, reservedTransform.childCount);

		Section s = reservedTransform.GetChild(r).GetComponent<Section>();

		SectionCategory targetCategory = LevelController.Instance.GetSectionCategoryFromLevel();

		int breakcount = 0;

		do
		{
			r = Random.Range(0, reservedTransform.childCount);

			s = reservedTransform.GetChild(r).GetComponent<Section>();

			breakcount++;

			if (breakcount > 100)
			{

				Debug.Log("Break");
				break;
			}
		}

		while (s.category != targetCategory || lastType == s.type);

		lastType = s.type;

		return s;
	}

	public Section GetUnactiveSection()
	{
		Section s = sections[Random.Range(0, sections.Count)];

		do
		{
			s = sections[Random.Range(0, sections.Count)];
		}
		while (s.transform.gameObject.activeSelf);



		return s;
	}

	Section GetSectionFromReservedByType(SectionType type)
	{

		int r = Random.Range(0, reservedTransform.childCount);

		Section s = reservedTransform.GetChild(r).GetComponent<Section>();

		int breakCount = 0;

		do
		{
			r = Random.Range(0, reservedTransform.childCount);

			s = reservedTransform.GetChild(r).GetComponent<Section>();

			breakCount++;

			if (breakCount > 1000)
			{
				break;
			}

		}
		while (s.type != type);

		return s;
	}

	Section GetSection(SectionType type)
	{
		Section s = null;
		for (int i = 0; i < reservedTransform.childCount; i++)
		{
			s = reservedTransform.GetChild(i).GetComponent<Section>();
			if (s.type == type)
			{
				s = reservedTransform.GetChild(i).GetComponent<Section>();
				return s;
			}
		}

		return s;
	}
}
