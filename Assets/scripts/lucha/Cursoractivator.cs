using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursoractivator : MonoBehaviour
{
    public bool ShowCursor;
  


    void Start()
    {
        if (ShowCursor == true)
        {
            Cursor.visible = true;
        }
    }


    
}
