using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeCar : MonoBehaviour
{
    List<GameObject> Cars = new List<GameObject>();

    public void MergeLevel1Cars()
    {
        if (CarSpawner.car1Count < 2)
            return;

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
            Cars[i].gameObject.SetActive(false);
        }
        Cars.Clear();
        Debug.Log("Cars Count: " + Cars.Count);    

    }
}
