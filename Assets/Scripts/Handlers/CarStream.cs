using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStream : MonoBehaviour {

	public static bool activateCars = true;
	private Section parentSection;

	public List<Transform> cars = new List<Transform>();

	public int direction = 1;

	private int currentCarIndex;

	private float timer;

	private float delay = 1f;

	private Transform stoppoint;

	private bool moveCars = true;

	void OnEnable()
	{
		EventManager.OnSectionPool += OnSectionPool;
	}
	void OnDisable()
	{
		EventManager.OnSectionPool -= OnSectionPool;
	}

	void OnSectionPool(SectionType type)
	{

	}

	void Start ()
	{
		Init();
	}

	private void CreateCars()
	{
		GameObject[] carList = GetCarList();

		for (int i = 0; i < GameController.MAX_CARS_PER_STREAM; i++)
		{
			GameObject clone = Instantiate(carList[Random.Range(0, carList.Length)]);

			clone.transform.SetParent(transform);

			clone.transform.position = Vector3.zero;

			clone.SetActive(false);

			clone.transform.rotation = Quaternion.Euler(new Vector3(0, direction * 90, 0));

			cars.Add(clone.transform);
		}
	}

	public GameObject[] GetCarList()
	{
		return AppResources.ZONE_CARS[parentSection.ZoneID - 1];
	}

	private void Init()
	{
		parentSection = transform.parent.parent.parent.GetComponent<Section>();

		CreateCars();

		timer = 1f;
	}

	void Update ()
	{
		if (GameController.TutorialEnabled)
		{
			if (!TutorialHandler.ActivateTutorialCars) return;
		}

		if (!activateCars) return;

		if (moveCars)
		{
			timer += Time.deltaTime;

			if (timer > delay)
			{
				MoveNextCar();

				timer = 0;
			}
		}
	}

	private void MoveNextCar()
	{
		Car car = cars[currentCarIndex].GetComponent<Car>();

		if (car.move == false)
		{
			car.transform.gameObject.SetActive(true);

			car.Move(transform.position, transform.GetChild(0).position, direction);

			float furyDelay = (FuryHandler.Instance.FuryTime > 1f) ? Random.Range(.6f, 1f) : (Random.Range(1f, 3f) * .8f);

			delay = furyDelay * GameController.CAR_STREAM_DELAY;


		}

		currentCarIndex++;

		if (currentCarIndex > cars.Count - 1)
		{
			currentCarIndex = 0;
		}
	}

	private void PlaceCarsAtStopPoint()
	{
		if (moveCars) { return; }

		for (int i = 0; i < cars.Count; i++)
		{

			cars[i].GetComponent<Car>().SetMove(false);

			if (i < cars.Count / 3)
			{
				Vector3 position = stoppoint.position;

				cars[i].gameObject.SetActive(true);

				cars[i].transform.position = position + new Vector3(-direction * i * 40f, transform.position.y, 0);
			}
		}
	}

	private void SetMove(bool b)
	{
		moveCars = b;

		for (int i = 0; i < cars.Count; i++)
		{
			cars[i].GetComponent<Car>().SetMove(moveCars);
		}
	}
}
