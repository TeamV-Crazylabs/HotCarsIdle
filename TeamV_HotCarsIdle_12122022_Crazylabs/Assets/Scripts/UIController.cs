using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] MergeCar mergeCar;
    [SerializeField] CarSpawner carSpawner;
    [SerializeField] AddPin addPin;

    [SerializeField] TextMeshProUGUI moneyIndicator;
    [SerializeField] Button mergeButton;
    [SerializeField] Button buyCarButton;
    [SerializeField] Button buyPinButton;

    [SerializeField] TextMeshProUGUI mergeCostText;
    [SerializeField] TextMeshProUGUI carCostText;
    [SerializeField] TextMeshProUGUI pinCostText;
    //[SerializeField] TextMeshProUGUI mapCostText;

    // Start is called before the first frame update
    void Start()
    {
        mergeButton.onClick.AddListener(() => { mergeCar.MergeCars(buyCarButton, mergeButton,mergeCostText); });
        buyCarButton.onClick.AddListener(() => { carSpawner.SpawnCar(buyCarButton, mergeButton,carCostText); });
        buyPinButton.onClick.AddListener(() => { addPin.BuyPin(buyPinButton,pinCostText); });
    }

    // Update is called once per frame
    void Update()
    {
        moneyIndicator.text = Money.totalDollars.ToString();

        if (Money.totalDollars<Money.mergeCost)
        {
            mergeButton.interactable = false;
        }
        else
        {
            mergeButton.interactable = true;
        }

        if (Money.totalDollars < Money.pinCost)
        {
            buyPinButton.interactable = false;
        }
        else
        {
            buyPinButton.interactable = true;
        }

        if (Money.totalDollars < Money.carCost)
        {
            buyCarButton.interactable = false;
        }
        else
        {
            buyCarButton.interactable = true;
        }
    }
}
