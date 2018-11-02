using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModelHandler : MonoBehaviour {

	public ParticleSystem[] exhaust;

	float startSize;
	float startLife;

	float furySize;
	float furyLife;

	void OnEnable () {
		EventManager.OnFingerUp += OnFingerUp;
		EventManager.OnFingerDown += OnFingerDown;
		EventManager.OnFuryStatus += OnFuryStatus;
	}

	void OnDisable () {
		EventManager.OnFingerUp -= OnFingerUp;
		EventManager.OnFingerDown -= OnFingerDown;
		EventManager.OnFuryStatus -= OnFuryStatus;
	}

	void Start()
	{
		startSize = Random.Range(.2f, .5f);
		startLife = Random.Range(.1f, .15f);

		furySize = Random.Range(.4f, .5f);
		furyLife = Random.Range(.7f, 1f);
		exhaust[0].Stop();
		exhaust[1].Stop();
	}

	void OnFingerUp()
	{
		exhaust[0].Stop();
		exhaust[1].Stop();
	}

	void OnFuryStatus(int i)
	{
		var main0 = exhaust[0].main;
		var main1 = exhaust[1].main;
		if (i == 0)
		{
			main0.startSize = startSize;
			main1.startSize = startSize;

			main0.startLifetime = startLife;
			main1.startLifetime = startLife;
		}
		else
		{

			main0.startSize = furySize;
			main1.startSize = furySize;

			main0.startLifetime = furyLife;
			main1.startLifetime = furyLife;
		}
	}

	void OnFingerDown()
	{
		exhaust[0].Play();
		exhaust[1].Play();

		var main0 = exhaust[0].main;
		var main1 = exhaust[1].main;
		if (FuryHandler.InFury == false)
		{
			main0.startSize = startSize;
			main1.startSize = startSize;

			main0.startLifetime = startLife;
			main1.startLifetime = startLife;

		}
		else
		{

			main0.startSize = furySize;
			main1.startSize = furySize;

			main0.startLifetime = furyLife;
			main1.startLifetime = furyLife;
		}
	}
}
