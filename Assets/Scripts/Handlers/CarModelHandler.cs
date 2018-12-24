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

	private bool pressed;

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
		ToggleThrust(false);
	}

	void OnFingerUp()
	{
		pressed = false;

		if (!FuryHandler.InFury)
		{
			ToggleThrust(false);
		}
	}

	void OnFuryStatus(int i)
	{
		if (i == 1)
		{
			ToggleThrust(ThrustType.Fury);
		}
		else
		{
			if (pressed)
			{
				ToggleThrust(ThrustType.Default);
			}
			else
			{
				ToggleThrust(false);
			}
		}
	}

	void OnFingerDown()
	{
		pressed = true;
		if (FuryHandler.InFury) return;
		ToggleThrust(ThrustType.Default);
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
