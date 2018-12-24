﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VehicleUpgradeHandler : MonoBehaviour {

	public VehicleAttributeButton speed;
	public VehicleAttributeButton durability;
	public VehicleAttributeButton furyTime;
	private ShowcaseModel hoveringVehicle;

	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
	}

	public void UpdateUpgradeUI(ShowcaseModel model)
	{

		speed.ValueText = model.speed.value.ToString();
		speed.CostText = model.speed.cost.ToString();
		speed.FillAmount = model.speed.fill;

		furyTime.ValueText = model.furyTime.value.ToString() + " s.";
		furyTime.CostText = model.furyTime.cost.ToString();
		furyTime.FillAmount = model.furyTime.fill;

		durability.ValueText = model.durability.value.ToString();
		durability.CostText = model.durability.cost.ToString();
		durability.FillAmount = model.durability.fill;

		hoveringVehicle = model;


	}

	private void OnButtonClick(ButtonID id)
	{
		if (hoveringVehicle == null) return;

		switch (id)
		{
			case ButtonID.UpgradeSpeed:
			{
				if (hoveringVehicle.speed.isMaxedOut()) break;
				hoveringVehicle.speed.AddValue(10);
				hoveringVehicle.speed.AddCost(20);
				hoveringVehicle.speed.IncrementTier();
				break;
			}

			case ButtonID.UpgradeDurability:
			{
				if (hoveringVehicle.durability.isMaxedOut()) break;
				hoveringVehicle.durability.AddValue(1);
				hoveringVehicle.durability.AddCost(20);
				hoveringVehicle.durability.IncrementTier();
				break;
			}
			case ButtonID.UpgradeFuryTime:
			{
				if (hoveringVehicle.furyTime.isMaxedOut()) break;
				hoveringVehicle.furyTime.AddValue(1);
				hoveringVehicle.furyTime.AddCost(20);
				hoveringVehicle.furyTime.IncrementTier();
				break;
			}
		}

		hoveringVehicle.Save();
		UpdateUpgradeUI(hoveringVehicle);
	}
}
