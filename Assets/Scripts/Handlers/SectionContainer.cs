using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionContainer : MonoBehaviour {

	public static List<Section> sections = new List<Section>();

	public static List<Section> generated = new List<Section>();

	public Transform reservedTransform;

	public Section lastReservedSection;

	private int defaultActive = 6;

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

		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_1);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_2);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_3);
		}
		for (int i = 0; i < 4; i++)
		{
			CreateSection(SectionType.Section_4);
		}
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
		RepositionSections();

	}

	private void RepositionSections()
	{

		List<Section> queue = new List<Section>();

		int r = Random.Range(0, reservedTransform.childCount);

		List<int> chosen = new List<int>();

		int index = 0;

		Section to = null;

		SectionType lastChosenType = SectionType.None;

		int breakCount = 0;

		do
		{

			breakCount++;

			if (breakCount > 100)
			{
				Debug.Log("Break");
				break;
			}

			if (index < 1)
			{
				to = GetSectionFromReservedByType(SectionType.Section_1);
			}
			else
			{
				r = Random.Range(0, reservedTransform.childCount);

				to = reservedTransform.GetChild(r).GetComponent<Section>();
			}

			if (to.ZoneID != 1) continue;

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


			Vector3 position = new Vector3(0, 0, 0);

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


			default: return AppResources.Section_1;
		}
	}

	private int sectionCount;

	int lastChosenIndex;

	public void PoolSection(Section section)
	{

		GameController.POOLED_SECTION++;

		section.transform.gameObject.SetActive(false);

		section.transform.SetParent(reservedTransform);

		Section s = GetSectionByZone();

		if (GameController.POOLED_SECTION > GameController.ZONE_CHANGE_EVERY)
		{
			GameController.CURRENT_ZONE++;
			s = GetSection(SectionType.Section_10);
			GameController.POOLED_SECTION = 0;
		}

		if (GameController.CURRENT_ZONE > 3)
		{
			GameController.CURRENT_ZONE = 1;
		}


		if (s.type == SectionType.Section_1)
		{
			sectionCount++;
		}

		if (sectionCount > 1)
		{
			s = GetSectionFromReservedByType(SectionType.Section_2);

			sectionCount = 0;
		}

		s.transform.SetParent(transform);

		s.transform.gameObject.SetActive(true);

		lastReservedSection = lastReservedSection == null ? sections[sections.Count - 1] : lastReservedSection;

		s.Move(lastReservedSection);

		lastReservedSection = s;
	}

	SectionType lastType = SectionType.None;

	public Section GetSectionByZone()
	{
		int r = Random.Range(0, reservedTransform.childCount);
		Section s = reservedTransform.GetChild(r).GetComponent<Section>();
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
		while (s.ZoneID != GameController.CURRENT_ZONE || lastType == s.type);

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
