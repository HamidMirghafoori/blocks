using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRoom : MonoBehaviour
{
    public GameObject[] trackers = new GameObject[4];
    public GameObject ballRoom;
    bool rotating = false;

    public void RotateLeft()
    {
    
        rotating = true;
    }

    public void RotateRight()
    {
        rotating = true;
    }

    
    void Start()
    {
       
    }

    
    void Update()
    {
        if (rotating)
        {
            ballRoom.transform.Rotate(Vector3.right * Time.deltaTime);

        }
    }
}
