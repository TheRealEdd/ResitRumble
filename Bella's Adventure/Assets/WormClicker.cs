using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormClicker : MonoBehaviour

{
    public int wormcounter;
    public float xcoo;
    public float ycoo;
    public Vector2 coordinates;
    // Start is called before the first frame update
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
