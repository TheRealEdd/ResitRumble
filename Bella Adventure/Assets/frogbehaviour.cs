using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogbehaviour : MonoBehaviour
{
    public float xcoo;
    public float ycoo;
    [SerializeField] public GameObject rock1;
    [SerializeField] public GameObject rock2;
    [SerializeField] public GameObject rock3;
    [SerializeField] public GameObject rock4;
    public Vector2 coordinates;
    public int targetrock;
    public Vector2 TargetrRockPos;
    public int prevTargetRock;
    float frameCounter=0;
    float frameCounter2=0;
    bool jumpHighest;
    bool touchfloor;
    float startY;
    GameObject scoredisplayer;
    // Start is called before the first frame update
    void Start()
    {
        jumpHighest = false;
        touchfloor = false;
        startY = this.transform.position.y;
        scoredisplayer = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        if (targetrock == 0)
        {
            targetrock = Random.Range(1, 5);
        }
        else if (targetrock == 1)
        {
            TargetrRockPos.Set(rock1.transform.position.x, rock1.transform.position.y);
        }
        else if (targetrock == 2)
        {
            TargetrRockPos.Set(rock1.transform.position.x, rock1.transform.position.y);
        }

        else if (targetrock == 3)
        {
            TargetrRockPos.Set(rock1.transform.position.x, rock1.transform.position.y);
        }

        else if (targetrock == 4)
        {
            TargetrRockPos.Set(rock1.transform.position.x, rock1.transform.position.y);
        }

        if (this.transform.position.y < 2 && jumpHighest == false)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 2, 0);
        }
        
        if(this.transform.position.y >= 2)
        {
            jumpHighest = true;
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
        }
        if(this.transform.position.y < startY) 
        {
            jumpHighest = false;
        }
    }




        /*if (this.transform.position.y <=2  && jumpHighest == false && frameCounter <= 2)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 2, 0);
            frameCounter += Time.deltaTime;
            if (frameCounter >= 2)
            {
                Debug.Log("miao");
                touchfloor = false;
                jumpHighest = true;
                frameCounter2 = 0;

            }


        }
        else if (frameCounter2 < 2 && touchfloor == false && frameCounter2 <=2)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
            frameCounter2 += Time.deltaTime;
            if (frameCounter2 >= 2)
            {
                Debug.Log("bau");
                touchfloor = true;
                jumpHighest = false;
                frameCounter = 0;

            }



        }*/


    
    void OnMouseDown()
    {
        xcoo = this.transform.position.x;
        ycoo = startY;
        coordinates.Set(xcoo, ycoo);
        transform.position = coordinates;
        scoredisplayer.gameObject.GetComponent<frogscoredisplayer>().frogcounter++;
    }
}
