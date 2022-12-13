using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private CarPool carPool = null;
    [SerializeField] Button buyCar;
    int carCount = 0;


    private void Start()
    {
        buyCar.onClick.AddListener(SpawnCar);
    }

    public void SpawnCar()
    {
        if (carCount <10 )
        {
            carPool.GetPooledObject();
            carCount += 1;
            Debug.Log("Car Count= " + carCount);
        }
        else
        {
            buyCar.interactable = false;
        }
    }

}
