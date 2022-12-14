using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeCar : MonoBehaviour
{
    List<GameObject> Cars = new List<GameObject>();
    CarPool carPool;
    [SerializeField] GameObject disappearingEffect;

    private void Start()
    {
        carPool = GetComponent<CarPool>();
    }
    public void MergeLevel1Cars(Button buyCar, Button mergeCar)
    {
        if(Cars != null)
        {
            Cars.Clear();
        }

        for (int i = 0; i < transform.GetChild(0).transform.childCount; i++)
        {
            if (transform.GetChild(0).GetChild(i).gameObject == null)
                return;

            if (transform.GetChild(0).GetChild(i).gameObject.activeInHierarchy)
                Cars.Add(transform.GetChild(0).GetChild(i).gameObject);
        }

        if (Cars == null)
            return;
        
        for (int i = 0; i < 2; i++)
        {
            //particle
            Debug.Log("Merge ife Girdi");
            Debug.Log("i = " + i);
            //Object Poola �evrilecek
            Instantiate(disappearingEffect, Cars[i].transform.position, Quaternion.identity);
            Cars[i].gameObject.SetActive(false);
            carPool.GetPooledObject(1);

            if (CarSpawner.car1Count < 10)
            {
                buyCar.interactable= true;
            }
            CarSpawner.car1Count--;
        }
        
        Debug.Log("Cars Count: " + Cars.Count);

        if (CarSpawner.car1Count < 2)
        {
            mergeCar.interactable = false;
        }

    }
}
