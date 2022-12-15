using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarSpawner : MonoBehaviour
{
    private CarPool carPool = null;
    public static int car1Count = 0;
    [SerializeField] Money money;

    private void Start()
    {
        carPool= GetComponent<CarPool>();
        car1Count = 1;
    }

    public void SpawnCar(Button buyCar, Button mergeCar,TextMeshProUGUI carCostText)
    {
        if (car1Count >= 1)
        {
            mergeCar.interactable= true;
        }
        if (car1Count < 10)
        {
            carPool.GetPooledObject(0);
            car1Count += 1;
            money.CarCost();
            carCostText.text = Money.carCost.ToString();

            Debug.Log("Car Count= " + car1Count);
        }
        else
        {
            buyCar.interactable = false;
        }
    }

}
