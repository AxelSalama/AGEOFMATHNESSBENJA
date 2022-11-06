using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    public GameObject btn;
    public GameObject txt;
    void Start()
    {
        Invoke("DesaparecerBoton", 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DesaparecerBoton()
    {
        btn.SetActive(false);
        txt.SetActive(true);
        Debug.Log("Funciona");

    }
}
