using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dejar : MonoBehaviour
{
    public GameObject queColider;
    public int correctas;

    public GameObject[] soportes = new GameObject[3];
    bool hayUnError;
    public Text txtNiveles;

    void Update()
    {

    }

    public void EnterResults()
    {
        for (int i = 0; i < soportes.Length; i++)
        {
            if (soportes[i].name != queColider.gameObject.name)
            {
                MostrarError();
                hayUnError = true;
                Debug.Log("a");
            }
            else if (hayUnError == false)
            {
                //ganar
            }
        }
        

    }
    public void MostrarError()
    {
        //se pone roja la base del soporte o aparece que barril esta mal
    }
   
}