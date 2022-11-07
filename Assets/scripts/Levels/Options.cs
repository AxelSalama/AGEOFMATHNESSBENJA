using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject seAbre;
    bool abierto = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AbrirOpciones()
    {
        Cerrar();
        seAbre.SetActive(true);
        abierto = true;

        
    }

    void Cerrar()
    {
        if (abierto == true)
        {
            seAbre.SetActive(false);
            abierto = false;
        }
    }
}
