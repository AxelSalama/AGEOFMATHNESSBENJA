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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = "Puntaje = "+contador.ToString();

        if (contador > 9)
        {
            //aca se abre la puerta al castillo y te deja pasar
            SceneManager.LoadScene("Reino multi");
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
}
