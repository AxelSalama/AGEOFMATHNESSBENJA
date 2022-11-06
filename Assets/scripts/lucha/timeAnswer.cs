using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeAnswer : MonoBehaviour
{
    //el tiempo empieza siendo 10, toca el boton attack empieza a contar y no deja tocar btncontinuar. 
    //Si contesta se inhabilta el input y se pausa el tiempo y se habilita btnContinuar. 
    //Si no contesta antes de los 10 segundos el tiempo se frena en 0 y en el text corrección 
    //aparece se te acabo el tiempo y se habilita el btnContinuar.

    float time;
    public GameObject btnContinuar;
    public GameObject Correcionando;
    public Text txtTiempo;
    public Text txtCorreccionando;
    public InputField Respuesta;

    public bool isCounting;
    public bool dejaSeguir;
    public bool inpEscribir;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            dejaSeguir = true;
            isCounting = false;
            inpEscribir = false;
        }

        if (isCounting == true)
        {
            timeResp();
        }

        if (dejaSeguir == true)
        {
            btnContinuar.GetComponent<Button>().interactable = true;
        }
        else
        {
            btnContinuar.GetComponent<Button>().interactable = false;
        }
        if (inpEscribir == true)
        {
            Respuesta.GetComponent<InputField>().interactable = true;
        }
        else
        {
            Respuesta.GetComponent<InputField>().interactable = false;
            isCounting = false;
        }
    }

    public void timeResp()
    {
        txtTiempo.text = Mathf.Floor(time + 1).ToString();
        time -= Time.deltaTime;

        if (time <= -1)
        {
            txtCorreccionando.text = "se te acabo el tiempo";
            Correcionando.SetActive(true);
            isCounting = false;
            dejaSeguir = true;
            inpEscribir = false;
        }
     
    }

    public void PressAttack()
    {
        isCounting = true;
        dejaSeguir = false;
        inpEscribir = true;
        time = 10;
    }
}
