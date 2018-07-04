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
		for (int i = 0; i < 7; i++)
		{
			CreateSection(SectionType.Section_7);
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

		do
		{

			if (index < 2)
			{
				to = GetSectionFromReservedByType(SectionType.Section_1);
			}
			else
			{
				r = Random.Range(4, reservedTransform.childCount);

				to = reservedTransform.GetChild(r).GetComponent<Section>();
			}

			if (!queue.Contains(to))
			{
				queue.Add(to);

				index++;
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
			case SectionType.Section_6: return AppResources.Section_6;
			case SectionType.Section_7: return AppResources.Section_7;

			default: return AppResources.Section_1;
		}
	}

	private int sectionCount;

	int lastChosenIndex;

	public void PoolSection(Section section)
	{

		GameController.POOLED_SECTION++;

		if (GameController.POOLED_SECTION > 4)
		{
			GameController.CURRENT_ZONE++;
			GameController.POOLED_SECTION = 0;
		}

		if (GameController.CURRENT_ZONE > 2)
		{
			GameController.CURRENT_ZONE = 1;
		}

		section.transform.gameObject.SetActive(false);

		section.transform.SetParent(reservedTransform);

		// int r = Random.Range(0, reservedTransform.childCount);

		// int breakCount = 0;
		// do
		// {
		// 	r = Random.Range(0, reservedTransform.childCount);
		// 	breakCount++;

		// 	if (breakCount > 100)
		// 	{
		// 		Debug.Log("Break");
		// 		break;
		// 	}
		// }
		// while (r == lastChosenIndex);

		// lastChosenIndex = r;

		Section s = GetSectionByZone();

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
		while (s.ZoneID != GameController.CURRENT_ZONE || lastChosenIndex == r);

		lastChosenIndex = r;

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
}
