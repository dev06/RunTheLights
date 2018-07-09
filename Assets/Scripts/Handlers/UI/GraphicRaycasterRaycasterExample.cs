using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class GraphicRaycasterRaycasterExample : MonoBehaviour
{
	GraphicRaycaster m_Raycaster;
	PointerEventData m_PointerEventData;
	EventSystem m_EventSystem;
	GameInput gameInput;
	public static bool HITTING_UI;

	void Start()
	{
		HITTING_UI = false;
		m_Raycaster = GetComponent<GraphicRaycaster>();
		m_EventSystem = GetComponent<EventSystem>();
		gameInput = FindObjectOfType<GameInput>();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Mouse0))
		{
			m_PointerEventData = new PointerEventData(m_EventSystem);
			m_PointerEventData.position = Input.mousePosition;

			List<RaycastResult> results = new List<RaycastResult>();

			m_Raycaster.Raycast(m_PointerEventData, results);

			if (results.Count > 0)
			{
				HITTING_UI = true;
				return;
			}

			HITTING_UI = false;
		}
		else
		{
			HITTING_UI = false;
		}
	}
}