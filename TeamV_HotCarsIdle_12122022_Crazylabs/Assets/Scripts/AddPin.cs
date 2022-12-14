using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddPin : MonoBehaviour
{
    public GameObject[] pins;
    public int pinCounter = 0;
    [SerializeField] Money money;

    public void BuyPin(Button addPinButton,TextMeshProUGUI pinCostText)
    {
        if (pinCounter < pins.Length)
        {
            pins[pinCounter].SetActive(true);
            pinCounter++;
            money.PinCost();
            pinCostText.text = Money.pinCost.ToString();
        }
        else
        {
            addPinButton.interactable= false;
            //Change Sprite to max pin sprite with interactable = false
        }

    }
}
