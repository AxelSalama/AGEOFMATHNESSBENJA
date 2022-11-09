using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerSuma : MonoBehaviour
{
    public EscenaData escenas;
    
    // Start is called before the first frame update
    void Start()
    {
        escenas.suma = true;
        escenas.resta = false;
        escenas.multi = false;
        escenas.divi = false;
    }

    
}
