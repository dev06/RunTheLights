using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VehicleUpgradeHandler : MonoBehaviour {

	public VehicleAttributeButton speed;
	public VehicleAttributeButton durability;
	public VehicleAttributeButton furyTime;
	public Text vehicleGearMultiplier;
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
		speed.CostText = (model.speed.isMaxedOut()) ? "-" : model.speed.cost.ToString();
		speed.FillAmount = model.speed.fill;

		furyTime.ValueText = model.furyTime.value.ToString() + " s.";
		furyTime.CostText = (model.furyTime.isMaxedOut()) ? "-" : model.furyTime.cost.ToString();
		furyTime.FillAmount = model.furyTime.fill;

		durability.ValueText = model.durability.value.ToString();
		durability.CostText = (model.durability.isMaxedOut()) ? "-" : model.durability.cost.ToString();
		durability.FillAmount = model.durability.fill;


		Color lockedColor = new Color(1f, .6f, .6f, 1f);
		speed.SetCostTextColor((GameController.Instance.gearsRemaining >= model.speed.cost) ? Color.white : lockedColor);
		durability.SetCostTextColor((GameController.Instance.gearsRemaining >= model.durability.cost) ? Color.white : lockedColor);
		furyTime.SetCostTextColor((GameController.Instance.gearsRemaining >= model.furyTime.cost) ? Color.white : lockedColor);

		vehicleGearMultiplier.text = "+" + (model.gearMultiplier * 100f) + "% more gears" ;

		hoveringVehicle = model;


	}

	private void OnButtonClick(ButtonID id)
	{
		if (hoveringVehicle == null) return;

		switch (id)
		{
			case ButtonID.UpgradeSpeed:
			{
				if (hoveringVehicle.speed.isMaxedOut() || !hoveringVehicle.speed.canPurchase()) break;
				hoveringVehicle.speed.AddValue(1);
				hoveringVehicle.speed.AddCost(10 * Mathf.RoundToInt(hoveringVehicle.gearMultiplier * 100));
				hoveringVehicle.speed.IncrementTier();
				speed.TriggerPop();
				break;
			}

			case ButtonID.UpgradeDurability:
			{
				if (hoveringVehicle.durability.isMaxedOut()  || !hoveringVehicle.durability.canPurchase()) break;
				hoveringVehicle.durability.AddValue(1);
				hoveringVehicle.durability.AddCost(10 * Mathf.RoundToInt(hoveringVehicle.gearMultiplier * 100));
				hoveringVehicle.durability.IncrementTier();
				durability.TriggerPop();
				break;
			}
			case ButtonID.UpgradeFuryTime:
			{
				if (hoveringVehicle.furyTime.isMaxedOut() || !hoveringVehicle.furyTime.canPurchase()) break;
				hoveringVehicle.furyTime.AddValue(1);
				hoveringVehicle.furyTime.AddCost(10 * Mathf.RoundToInt(hoveringVehicle.gearMultiplier * 100));
				hoveringVehicle.furyTime.IncrementTier();
				furyTime.TriggerPop();
				break;
			}
		}

		hoveringVehicle.Save();
		UpdateUpgradeUI(hoveringVehicle);
	}
}
