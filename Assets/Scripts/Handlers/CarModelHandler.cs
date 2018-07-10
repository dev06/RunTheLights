using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModelHandler : MonoBehaviour {

	public ParticleSystem[] exhaust;



	void OnEnable () {
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
	}

	void OnDisable () {
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
	}

	void Start()
	{
		exhaust[0].Stop();
		exhaust[1].Stop();
	}

	void OnFingerUp()
	{
		exhaust[0].Stop();
		exhaust[1].Stop();
	}

	void OnFingerDown()
	{
		exhaust[0].Play();
		exhaust[1].Play();
	}
}
