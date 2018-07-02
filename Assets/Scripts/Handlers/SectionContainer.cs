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
				r = Random.Range(0, reservedTransform.childCount);

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
			default: return AppResources.Section_1;
		}
	}

	private int sectionCount;

	public void PoolSection(Section section)
	{

		//Test.T(section);
		//PrefabUtility.ReplacePrefab(section, section.prefab, ReplacePrefabOptions.ConnectToPrefab);

		section.transform.gameObject.SetActive(false);

		section.transform.SetParent(reservedTransform);

		int r = Random.Range(0, reservedTransform.childCount);

		Section s = reservedTransform.GetChild(r).GetComponent<Section>();

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
