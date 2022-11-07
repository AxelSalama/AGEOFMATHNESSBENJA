using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{    
    public GameObject Cuenta;
    public GameObject Ataque;
    public GameObject Escape;
    public GameObject Lugar;
    public GameObject btnContinuar;


    private void awake()
    {
      // eligecuenta = Lugar.GetComponent<EligeCuenta>();
    }

    private void Start()
    {
        Cuenta.SetActive(false);
        Ataque.SetActive(true);
        //eligecuenta.timeResp();
        
    }


    public void Activar()
    {
        Cuenta.SetActive(true);
        btnContinuar.transform.localPosition = new Vector3(115, -145, 0);
        Ataque.SetActive(false);
        Escape.transform.localScale = new Vector3(1, 1, 1);
        Escape.transform.localPosition = new Vector3(375, -220, 0);
        //eligecuenta.isCounting = true;
    }

    public void Desactivar()
    {
        Cuenta.SetActive(false);
        Ataque.SetActive(true);
        //eligecuenta.isCounting = false;
    }
}
