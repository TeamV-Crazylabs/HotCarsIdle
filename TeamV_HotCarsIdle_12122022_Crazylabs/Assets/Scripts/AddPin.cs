using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPin : MonoBehaviour
{
    public GameObject[] pins;
    public int pinCounter = 0;
    
    public void BuyPin(Button addPinButton)
    {
        if (pinCounter < pins.Length)
        {
            pins[pinCounter].SetActive(true);
            pinCounter++;
        }
        else
        {
            addPinButton.interactable= false;
            //Change Sprite to max pin sprite with interactable = false
        }

    }
}
