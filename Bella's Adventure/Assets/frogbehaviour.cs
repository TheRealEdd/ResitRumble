using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogbehaviour : MonoBehaviour
{
    public float xcoo;
    public float ycoo;
    public Vector2 coordinates;
    public int targetrock;
    public Vector2 TargetrRockPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetrock == 0)
        {
            targetrock =Random.Range(1, 5); 
        }
        else if (targetrock == 1)
        {
            TargetrRockPos.Set(-7.93f, -1.47f);
        }
        else if (targetrock == 2)
        {
            TargetrRockPos.Set(-2.83f, -0.15f);
        }

        else if (targetrock == 3)
        {
            TargetrRockPos.Set(-0.82f, -3.345f);
        }

         else if (targetrock == 4)
        {
            TargetrRockPos.Set(-2.55f, -0.45f);
        }

        else if (targetrock == 5)
        {
            TargetrRockPos.Set(-6.56f, -2.86f);
        }





    }

    void OnMouseDown()
    {
        xcoo = Random.Range(-3, 3);
        ycoo = Random.Range(-3, 3);
        coordinates.Set(xcoo, ycoo);
        transform.position = coordinates;
    }
}
