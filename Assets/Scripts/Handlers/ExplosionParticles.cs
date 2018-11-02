using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticles : MonoBehaviour {


	private List<ParticleSystem> explosions = new List<ParticleSystem>();

	private int index = 0;

	void Start () {

		for (int i = 0; i < transform.childCount; i++)
		{
			explosions.Add(transform.GetChild(i).GetComponent<ParticleSystem>());
		}

	}

	public void TriggerParticles(Vector3 position)
	{
		ParticleSystem exp = explosions[index];

		exp.transform.position = position;

		exp.Play();

		index++;

		if (index > explosions.Count - 1)
		{
			index = 0;
		}
	}
}
