using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpawner : MonoBehaviour
{
    private CarPool carPool = null;
    public static int car1Count = 0;


    private void Start()
    {
        carPool= GetComponent<CarPool>();
    }

    public void SpawnCar(Button buyCar, Button mergeCar)
    {
        if (car1Count >= 1)
        {
            mergeCar.interactable= true;
        }
        if (car1Count < 10)
        {
            carPool.GetPooledObject(0);
            car1Count += 1;
            Debug.Log("Car Count= " + car1Count);
        }
        else
        {
            buyCar.interactable = false;
        }
    }

}
