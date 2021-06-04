using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour
{

    

    // Start is called before the first frame update
    public Texture2D cursor;


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

}

