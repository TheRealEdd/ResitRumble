using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class texthandler : MonoBehaviour
{
    public Text text;
    public GameObject  wormscript;
    public int texttochangein;
    public int newtext;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        newtext = wormscript.gameObject.GetComponent<worm>().wormcounter;
        text.text = newtext.ToString();
    }
}
       
