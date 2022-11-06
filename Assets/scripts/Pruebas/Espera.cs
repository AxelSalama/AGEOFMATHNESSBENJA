using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espera : MonoBehaviour
{
    public bool algo = true;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EsperarXSegundos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EsperarXSegundos()
    {
        Debug.Log("Esto se scribe de la pausa");
        algo = false;
        yield return new WaitForSeconds(2);
        algo = true;
        Debug.Log("Esto se escribe despues de la pausa");
    }
}
