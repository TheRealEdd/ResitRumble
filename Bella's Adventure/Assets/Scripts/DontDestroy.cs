using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public bool otisComplete;
    public bool daisyComplete;
    public bool alexaComplete;
    public bool oscarComplete;
    public bool MyFunctionCalled;
 
    public static DontDestroy instance;
    // Start is called before the first frame update
    void Start()
    {
        otisComplete = false;
        daisyComplete = false;
        alexaComplete = false;
        oscarComplete = false;
        MyFunctionCalled = false;
        


        if (instance != null)
        {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        {
        Scene sceneLoaded=SceneManager.GetActiveScene();
        // Debug.Log(sceneLoaded.buildIndex);

        if(sceneLoaded.buildIndex == 12){
            otisComplete = true;
        }

        if(sceneLoaded.buildIndex == 17){
            daisyComplete = true;
        }

        if(sceneLoaded.buildIndex == 19){
            oscarComplete = true;
        }

        if(sceneLoaded.buildIndex == 26){
            alexaComplete = true;
        }
        if(sceneLoaded.buildIndex == 6 || sceneLoaded.buildIndex == 7){
    if (otisComplete == true && daisyComplete == true && alexaComplete == true && oscarComplete && true && MyFunctionCalled == false) {
            MyFunctionCalled = true;
            SceneManager.LoadScene (sceneBuildIndex:27);
            
    }
     
    }
    }
}


}