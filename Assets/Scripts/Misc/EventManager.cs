using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void Section(SectionType type);

	public static Section OnSectionPool;


	public delegate void Gameplay();
	public static Gameplay OnHitObject;
	public static Gameplay OnUpdateUI;
	public static Gameplay OnZoneComplete;
	public static Gameplay OnGameOver;



	public delegate void ProgressionCollider(ProgressionColliderType type);
	public static ProgressionCollider OnProgressionColliderHit;
}
