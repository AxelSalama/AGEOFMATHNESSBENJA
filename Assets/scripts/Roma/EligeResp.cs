using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EligeResp : MonoBehaviour
{
    bool esCorrecta;
    public NroRandom nrorandom;
    public int contador;
    public Text puntaje;
    public GameObject reja;
    public GameObject triggon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = "Puntaje = "+contador.ToString();

        if (contador > 2)
        {
            reja.SetActive(false);
            triggon.SetActive(true);
            SceneManager.LoadScene("Lucha rey");
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == nrorandom.mezcla.ToString())
        {
            esCorrecta = true;
            Debug.Log(esCorrecta);
        }
        else if (other.tag != nrorandom.mezcla.ToString())
        {
            esCorrecta = false;
            Debug.Log(esCorrecta);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if(col.tag == nrorandom.mezcla.ToString())
        {
            nrorandom.NroFinal = Random.Range(1, 20);

            nrorandom.Romanificar();
            nrorandom.MezclarOpciones();
            
            contador++;
        }
    }
    private void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "triggerReja")
        {
            SceneManager.LoadScene("Lucha rey");
            Debug.Log("entraste");
        }
    }
}
