using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPool : MonoBehaviour
{
    private Queue<GameObject> pooledCar;
    [SerializeField] private GameObject firsCarPrefab;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        pooledCar = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(firsCarPrefab);
            obj.SetActive(false);
            pooledCar.Enqueue(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        GameObject obj = pooledCar.Dequeue();
        obj.SetActive(true);
        pooledCar.Enqueue(obj);
        return obj;
    }
}
