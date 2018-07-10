using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModelHandler : MonoBehaviour {

	public ParticleSystem[] exhaust;

	void Start () {

	}

	void Update ()
	{
		if (Section.VELOCITY > 0)
		{
			if (!exhaust[0].isPlaying)
			{
				exhaust[0].Play();
			}

			if (!exhaust[1].isPlaying)
			{
				exhaust[1].Play();
			}
		}
		else
		{
			exhaust[0].Stop();
			exhaust[1].Stop();
		}
	}
}
