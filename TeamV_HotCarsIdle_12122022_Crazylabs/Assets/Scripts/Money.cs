using UnityEngine;

public class Money : MonoBehaviour
{
    public static int totalDollars;

    public static int carCost;
    public static int pinCost;
    public static int mergeCost;
    public static int mapCost;
    void Start()
    {
        carCost = 0;
        pinCost = 0;
        mergeCost =0;
        mapCost = 0;
        //playerprefs
        totalDollars = 0;
    }

    public void CarCost()
    {
        totalDollars -= carCost;
        carCost += Random.Range(20, 26);
    }
    public void PinCost()
    {
        totalDollars -= pinCost;
        pinCost += Random.Range(120, 250);
    }
    public void MergeCost()
    {
        totalDollars -= mergeCost;
        mergeCost += Random.Range(70, 80);
    }
    public void MapCost()
    {
        totalDollars -= mapCost;
        mapCost += 1000;
    }
}
