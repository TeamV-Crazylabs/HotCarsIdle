using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeCar : MonoBehaviour
{
    List<GameObject> Cars = new List<GameObject>();
    [SerializeField] GameObject disappearingEffect;


    public void MergeLevel1Cars(Button buyCar, Button mergeCar)
    {

        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject == null)
                return;

            if (transform.GetChild(i).gameObject.activeInHierarchy)
                Cars.Add(transform.GetChild(i).gameObject);
        }

        if (Cars == null)
            return;
        
        for (int i = 0; i < 2; i++)
        {
            //particle
            Debug.Log("Merge ife Girdi");
            CarSpawner.car1Count--;
            //Object Poola Çevrilecek
            Instantiate(disappearingEffect, Cars[i].transform.position, Quaternion.identity);

            Cars[i].gameObject.SetActive(false);

            if (CarSpawner.car1Count < 10)
            {
                buyCar.interactable= true;
            }
        }
        Cars.Clear();
        Debug.Log("Cars Count: " + Cars.Count);

        if (CarSpawner.car1Count < 2)
        {
            mergeCar.interactable = false;
        }

    }
}
