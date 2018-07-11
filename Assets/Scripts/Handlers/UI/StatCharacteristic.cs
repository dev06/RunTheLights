using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum StatType
{
	None,
	Speed,
	Acceleration,
	Deceleration,
	Power,
}
public class StatCharacteristic : MonoBehaviour {

	public StatType type;

	private float targetValue;

	public Image fillImage;

	private float vel;

	private float speed, acceleration, deceleration, power;

	void OnEnable()
	{
		EventManager.OnShowcaseModelHover += OnShowcaseModelHover;
	}
	void OnDisable()
	{
		EventManager.OnShowcaseModelHover -= OnShowcaseModelHover;
	}

	void OnShowcaseModelHover(ShowcaseModel model)
	{
		this.speed = model.speed;
		this.acceleration = model.acceleration;
		this.deceleration = model.deceleration;
		this.power = model.power;
	}

	void Update()
	{
		targetValue = GetTargetValue();
		fillImage.fillAmount = Mathf.SmoothDamp(fillImage.fillAmount, targetValue, ref vel, Time.deltaTime * 10f);
	}

	private float GetTargetValue()
	{
		switch (type)
		{
			case StatType.Speed:
			{
				return speed / GameController.MAX_CAR_SPEED;
			}
			case StatType.Acceleration:
			{
				return acceleration / GameController.MAX_CAR_ACC;
			}
			case StatType.Deceleration:
			{
				return deceleration / GameController.MAX_CAR_DEC;
			}

			case StatType.Power:
			{
				return power / GameController.MAX_CAR_POWER;
			}

		}

		return 0;
	}
}
