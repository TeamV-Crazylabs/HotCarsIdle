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
    // Start is called before the first frame update
    void Start()
    {
        mergeButton.onClick.AddListener(() => { mergeCar.MergeCars(buyCarButton, mergeButton); });
        buyCarButton.onClick.AddListener(() => { carSpawner.SpawnCar(buyCarButton, mergeButton); });
        buyPinButton.onClick.AddListener(() => { addPin.BuyPin(buyPinButton); });
    }

    // Update is called once per frame
    void Update()
    {
        moneyIndicator.text = Money.totalDollars.ToString();
    }
}
