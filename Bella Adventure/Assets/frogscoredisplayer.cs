using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogscoredisplayer : MonoBehaviour
{
    public int frogcounter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = frogcounter.ToString();
        if (frogcounter == 10)
        {
            this.GetComponent<UnityEngine.UI.Text>().text = "You have enough worms, you won!";
        }


    }
}
