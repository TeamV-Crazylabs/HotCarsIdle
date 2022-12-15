using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MergeCar : MonoBehaviour
{
    List<GameObject> Cars = new List<GameObject>();
    CarPool carPool;
    CarUnlocker carUnlocker;
    [SerializeField] GameObject disappearingEffect;
    [SerializeField] Money money;
    int carIndex = 0;

    private void Start()
    {
        carPool = GetComponent<CarPool>();
        carUnlocker = GetComponent<CarUnlocker>();
        Debug.Log("Car index: " + carIndex);
    }
    public void MergeCars(Button buyCar, Button mergeCar, TextMeshProUGUI MergeCostText)
    {
        Debug.Log("Car index: " + carIndex);
        if (Cars != null)
        {
            Cars.Clear();
        }

        //When more cars added the condition must be changed.
        if (carIndex >= 9)
        {
            Debug.Log("Reached Maximum Car Level");
            mergeCar.interactable = false;
            carIndex = 0;
            return;
        }

        //Gets List of Active Cars under Carpool
        for (int i = 0; i < transform.GetChild(carIndex).transform.childCount; i++)
        {
            if (transform.GetChild(carIndex).GetChild(i).gameObject == null)
                return;

            if (transform.GetChild(carIndex).GetChild(i).gameObject.activeInHierarchy)
                Cars.Add(transform.GetChild(carIndex).GetChild(i).gameObject);
        }

        if (Cars == null || Cars.Count < 2)
        {
            Debug.Log("car index increased");
            carIndex++;
            MergeCars(buyCar,mergeCar,MergeCostText);
        }
        else
        {
            for (int i = 0; i < 2; i++)
            {
                //particle
                //Object Poola �evrilecek
                Instantiate(disappearingEffect, Cars[i].transform.position, Quaternion.identity);
                Cars[i].gameObject.SetActive(false);
                CountFirstLevelCars(buyCar, carIndex);

            }
            
            carPool.GetPooledObject(carIndex + 1);
            carUnlocker.UnlockCar(carIndex + 1);
            carIndex = 0;
            money.MergeCost();
            MergeCostText.text = Money.mergeCost.ToString();
        }
    }

    //Controls Car Buy Button Interactable Situation
    void CountFirstLevelCars(Button carBuyingButton, int carLevel)
    {
        //If merged cars are not first level cars. Does not counts and returns.
        if (carIndex != 0)
            return;
        CarSpawner.car1Count--;
        Debug.Log("Car count eksildi. Car count: " + CarSpawner.car1Count);
        if (CarSpawner.car1Count < 10)
        {
            carBuyingButton.interactable = true;
        }
    }

}
