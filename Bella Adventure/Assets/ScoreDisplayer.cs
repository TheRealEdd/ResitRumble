using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplayer : MonoBehaviour
{
  
    public int wormcounter;
    public int frogcounter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = wormcounter.ToString();
        if (wormcounter == 5)
        {
            this.GetComponent<UnityEngine.UI.Text>().text = " you won!";
        }
        

    }
}
