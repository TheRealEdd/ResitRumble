using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worm : MonoBehaviour
{
    GameObject scoredisplayer;
    public int wormcounter;
    public float xcoo;
    public float ycoo;
    public Vector2 coordinates;
    void Start()
    {
        scoredisplayer = GameObject.Find("Text");
    }
    void Update()
    {


    }

    void OnMouseDown()
    {
        scoredisplayer.GetComponent<ScoreDisplayer>().wormcounter++ ;
        xcoo = Random.Range(-3, 3);
        ycoo = Random.Range(-3, 3);
        coordinates.Set(xcoo, ycoo);
        transform.position = coordinates;
    }

}

