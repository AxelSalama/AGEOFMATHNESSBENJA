using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject seAbre;
    public GameObject volver;
    public GameObject options;
    public DificultadData dificultad;
    public GameObject fondiu;

    public void AbrirOpciones()
    {
        
        seAbre.SetActive(true);
        volver.SetActive(true);
        options.SetActive(false);
        fondiu.SetActive(false);
    }
    public void CerrarOpciones()
    {
        fondiu.SetActive(true);
        seAbre.SetActive(false);
        volver.SetActive(false);
        options.SetActive(true);

    }
    public void facil()
    {
        dificultad.facil = true;
        dificultad.dificil = false;
        dificultad.imposible = false;
    }
    public void dificil()
    {
        dificultad.facil = false;
        dificultad.dificil = true;
        dificultad.imposible = false;
    }
    public void imposible()
    {
        dificultad.facil = false;
        dificultad.dificil = false;
        dificultad.imposible = true;
    }


}
