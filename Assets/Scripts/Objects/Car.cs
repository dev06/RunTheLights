using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {


	public bool move;

	private int direction;

	public float CarSpeed = 100f;

	public Transform smoke;

	private Vector3 targetPosition;

	private MeshRenderer mesh;


	private bool carHit;

	private CarStream parentCarStream;


	void Start ()
	{
		CarSpeed = 10f;

		mesh = transform.GetComponentInChildren<MeshRenderer>();
	}


	void Update ()
	{


		if (!move) { return; }

		transform.Translate(direction * Vector3.right * Time.deltaTime * CarSpeed, Space.World);

		//transform.position += new Vector3(0, Mathf.PingPong(Time.realtimeSinceStartup * 1f, .06f) - .03f, 0);
	}

	public void Move(Vector3 startingPos, Vector3 target, int direction)
	{
		Toggle(true);
		move = true;
		transform.position = startingPos + new Vector3(0, 0, Random.Range(-.2f, .2f));
		this.direction = direction;
	}


	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Trigger/Carpool")
		{
			move = false;
			transform.gameObject.SetActive(false);
			CarHit = false;
		}
	}

	public void Toggle(bool b)
	{
		if (mesh == null)
		{
			mesh = transform.GetComponentInChildren<MeshRenderer>();
		}
		mesh.enabled = b;
	}

	public bool CarHit
	{
		get {return carHit;}
		set { this.carHit = value; }
	}

	public CarStream ParentCarStream
	{
		get {return parentCarStream; }
		set {this.parentCarStream = value;}
	}
}
