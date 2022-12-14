using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            //1 dolar partcile play
            Money.totalDollars += 1;
        }
        else if (collision.gameObject.layer == 11)
        {
            //1 dolar partcile play
            Money.totalDollars += 5;
        }
        else if (collision.gameObject.layer == 12)
        {
            //1 dolar partcile play
            Money.totalDollars += 25;
        }
        else if (collision.gameObject.layer == 13)
        {
            //1 dolar partcile play
            Money.totalDollars += 125;
        }
        else if (collision.gameObject.layer == 14)
        {
            //1 dolar partcile play
            Money.totalDollars += 625;
        }
        else if (collision.gameObject.layer == 15)
        {
            //1 dolar partcile play
            Money.totalDollars += 25;
        }
    }
}
