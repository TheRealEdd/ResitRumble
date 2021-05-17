using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worm : MonoBehaviour
{
    
    public int wormcounter;
    public float xcoo;
    public float ycoo;
    public Vector2 coordinates;
    void Start()
    {

    }

    void Update()
    {


    }

    void OnMouseDown()
    {
        wormcounter++;
        xcoo = Random.Range(-5, 5);
        ycoo = Random.Range(-5, 5);
        coordinates.Set(xcoo, ycoo);
        transform.position = coordinates;
    }

}

