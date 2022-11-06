using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seDeja : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "soporte")
        {

            other.GetComponentInParent<Dejar>().queColider = this.gameObject;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "soporte")
        {
            other.GetComponentInParent<Dejar>().queColider = null;
        }
    }
}
