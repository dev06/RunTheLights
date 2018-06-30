using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void Section(SectionType type); 

	public static Section OnSectionPool; 
}
