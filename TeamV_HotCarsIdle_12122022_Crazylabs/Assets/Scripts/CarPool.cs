using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPool : MonoBehaviour
{
    List<Queue<GameObject>> objectPoolsList;
    Queue<GameObject> pooledLevel1Car;
    Queue<GameObject> pooledLevel2Car;
    Queue<GameObject> pooledLevel3Car;
    [SerializeField] private GameObject[] CarPrefabs;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        objectPoolsList = new List<Queue<GameObject>>();
        pooledLevel1Car = new Queue<GameObject>();
        pooledLevel2Car = new Queue<GameObject>();
        pooledLevel3Car = new Queue<GameObject>();
        objectPoolsList.Add(pooledLevel1Car);
        objectPoolsList.Add(pooledLevel2Car);
        objectPoolsList.Add(pooledLevel3Car);

        CreatePools();
    }

    void CreatePools()
    {
        Debug.Log("Objectpoolslist.count: " + objectPoolsList.Count);
        Debug.Log("Car Prefabs Count: " + CarPrefabs.Length);
        for (int i = 0; i < objectPoolsList.Count; i++)
        {
            for (int j = 0; j < poolSize; j++)
            {
                GameObject obj = Instantiate(CarPrefabs[i]);
                obj.SetActive(false);
                objectPoolsList[i].Enqueue(obj);
                obj.transform.parent = gameObject.transform.GetChild(i).transform;
            }
        }
    }


    public GameObject GetPooledObject(int carLevel)
    {
        GameObject obj = objectPoolsList[carLevel].Dequeue();
        obj.SetActive(true);
        pooledLevel1Car.Enqueue(obj);
        return obj;
    }
}
