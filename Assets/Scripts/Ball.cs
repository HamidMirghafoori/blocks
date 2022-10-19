using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float timer;
    Vector3 rotationRate;

    void Start()
    {
        Random.InitState(100);

        timer = 2;
        rotationRate = new Vector3(Random.Range(0f, 80f), Random.Range(0f, 80f), Random.Range(0f, 80f));
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 2;
            rotationRate = new Vector3(Random.Range(0f, 80f), Random.Range(0f, 80f), Random.Range(0f, 80f));
        }
        transform.Rotate(rotationRate * Time.deltaTime);

    }
}
