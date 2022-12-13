using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] MergeCar mergeCar;
    [SerializeField] CarSpawner carSpawner;

    [SerializeField] TextMeshProUGUI moneyIndicator;
    [SerializeField] Button mergeButton;
    [SerializeField] Button buyCarButton;
    // Start is called before the first frame update
    void Start()
    {
        mergeButton.onClick.AddListener(mergeCar.MergeLevel1Cars);
        buyCarButton.onClick.AddListener(() => { carSpawner.SpawnCar(buyCarButton); });
    }

    // Update is called once per frame
    void Update()
    {
        moneyIndicator.text = Money.totalDollars.ToString();
    }
}
