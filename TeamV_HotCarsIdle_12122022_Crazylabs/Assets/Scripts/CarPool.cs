using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPool : MonoBehaviour
{
    List<Queue<GameObject>> objectPoolsList = new List<Queue<GameObject>>();
    Queue<GameObject> pooledLevel1Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel2Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel3Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel4Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel5Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel6Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel7Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel8Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel9Car = new Queue<GameObject>();
    Queue<GameObject> pooledLevel10Car = new Queue<GameObject>();
    [SerializeField] private GameObject[] CarPrefabs;
    [SerializeField] private int poolSize;

    private void Awake()
    {
        objectPoolsList.Add(pooledLevel1Car);
        objectPoolsList.Add(pooledLevel2Car);
        objectPoolsList.Add(pooledLevel3Car);
        objectPoolsList.Add(pooledLevel4Car);
        objectPoolsList.Add(pooledLevel5Car);
        objectPoolsList.Add(pooledLevel6Car);
        objectPoolsList.Add(pooledLevel7Car);
        objectPoolsList.Add(pooledLevel8Car);
        objectPoolsList.Add(pooledLevel9Car);
        objectPoolsList.Add(pooledLevel10Car);

        CreatePools();
    }

    void CreatePools()
    {
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
        objectPoolsList[carLevel].Enqueue(obj);
        return obj;
    }
}
