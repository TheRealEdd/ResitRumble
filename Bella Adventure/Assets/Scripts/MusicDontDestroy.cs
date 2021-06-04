using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicDontDestroy : MonoBehaviour
{
    void Awake()
    {
      
    }

    
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Name: " + scene.name);
        DontDestroyOnLoad(transform.gameObject);

        if (scene.name == "2_IntroCaveScene")
        {
            Destroy(gameObject);
        }
    }
}
