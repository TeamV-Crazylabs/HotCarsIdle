using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private CarPool carPool = null;
    [SerializeField] Button buyCar;
    int car1Count = 0;


    private void Start()
    {
        buyCar.onClick.AddListener(SpawnCar);
    }

    public void SpawnCar()
    {
        if (car1Count < 10)
        {
            carPool.GetPooledObject();
            car1Count += 1;
            Debug.Log("Car Count= " + car1Count);
        }
        else
        {
            buyCar.interactable = false;
        }
    }

}
