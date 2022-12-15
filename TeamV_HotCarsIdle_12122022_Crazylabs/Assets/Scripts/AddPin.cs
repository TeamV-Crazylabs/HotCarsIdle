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
    public static bool pinIsMax;

    public void BuyPin(Button addPinButton,TextMeshProUGUI pinCostText)
    {
        if (pinCounter < pins.Length)
        {
            pins[pinCounter].SetActive(true);
            pinCounter++;
            money.PinCost();
            pinCostText.text = Money.pinCost.ToString();
            Debug.Log(pinCounter);
        }
        else
        {
            pinIsMax= true;
            addPinButton.interactable= false;
            
            pinCostText.text = "MAX";
            //Change Sprite to max pin sprite with interactable = false
        }

    }
}
