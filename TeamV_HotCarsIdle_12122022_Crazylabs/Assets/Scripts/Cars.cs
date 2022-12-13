using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    float timer;
    [SerializeField] GameObject CarTrail;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpeedUp();
    }


    public void SpeedUp()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            timer = 0;
            Time.timeScale = 2f;
            CarTrail.SetActive(true);
        }

        if (timer >= 1f)
        {
            Time.timeScale = 1f;
            CarTrail.SetActive(false);
        }
    }
}
