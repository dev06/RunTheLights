using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ThrustType
{
	Default, Fury,
}

public class CarModelHandler : MonoBehaviour {

	public Transform defaultThrust;

	public Transform furyThrust;

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
		ToggleThrust(false);
	}

	void OnFingerUp()
	{
		ToggleThrust(false);
	}

	void OnFuryStatus(int i)
	{

		ToggleThrust((i == 1) ? ThrustType.Fury : ThrustType.Default);
		// var main0 = exhaust[0].main;
		// var main1 = exhaust[1].main;
		// if (i == 0)
		// {
		// 	main0.startSize = startSize;
		// 	main1.startSize = startSize;

		// 	main0.startLifetime = startLife;
		// 	main1.startLifetime = startLife;
		// }
		// else
		// {

		// 	main0.startSize = furySize;
		// 	main1.startSize = furySize;

		// 	main0.startLifetime = furyLife;
		// 	main1.startLifetime = furyLife;
		// }
	}

	void OnFingerDown()
	{
		ToggleThrust(FuryHandler.InFury ? ThrustType.Fury : ThrustType.Default);

		// var main0 = exhaust[0].main;
		// var main1 = exhaust[1].main;
		// if (FuryHandler.InFury == false)
		// {
		// 	main0.startSize = startSize;
		// 	main1.startSize = startSize;

		// 	main0.startLifetime = startLife;
		// 	main1.startLifetime = startLife;

		// }
		// else
		// {

		// 	main0.startSize = furySize;
		// 	main1.startSize = furySize;

		// 	main0.startLifetime = furyLife;
		// 	main1.startLifetime = furyLife;
		// }
	}


	void ToggleThrust(bool b)
	{
		ToggleFuryThrust(b);
		ToggleDefaultThrust(b);
	}

	void ToggleThrust(ThrustType type)
	{
		if (type == ThrustType.Default)
		{
			ToggleFuryThrust(false);
			ToggleDefaultThrust(true);
		}
		else
		{
			ToggleDefaultThrust(false);
			ToggleFuryThrust(true);
		}
	}

	void ToggleDefaultThrust(bool b)
	{
		if (defaultThrust == null) return;

		for (int i = 0; i < defaultThrust.childCount; i++)
		{
			ParticleSystem ps = defaultThrust.GetChild(i).GetComponent<ParticleSystem>();

			if (b)
			{
				ps.Play();
			}
			else
			{
				ps.Stop();
			}
		}
	}

	void ToggleFuryThrust(bool b)
	{
		if (furyThrust == null) return;
		for (int i = 0; i < furyThrust.childCount; i++)
		{
			ParticleSystem ps = furyThrust.GetChild(i).GetComponent<ParticleSystem>();

			if (b)
			{
				ps.Play();
			}
			else
			{
				ps.Stop();
			}
		}
	}
}
