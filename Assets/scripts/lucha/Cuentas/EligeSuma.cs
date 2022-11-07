using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EligeSuma : MonoBehaviour
{
    public GameObject btnContinuar;

    public Text N1Text;
    public Text N2Text;
    public Text operacion;

    int minInt = 1;
    int maxInt = 10;

    int randomnum;
    int randomnum2;

    public InputField Respuesta;

    int insertRes;
    public int res;

    public Text correccionando;
    public GameObject correccionado;

    public bool correcta;

    public DificultadData nivel;

    public void Start()
    {
        if (nivel.facil == true)
        {
            minInt = 2;
            maxInt = 15;
        }
        else if (nivel.dificil == true)
        {
            minInt = 15;
            maxInt = 40;
        }
        else if (nivel.imposible == true)
        {
            minInt = 40;
            maxInt = 99;
          
        }

        //RandomizarDivi();
        //RandomizarResta();
        RandomizarEnTexto();
        //RandomizarMulti();

        correccionado.SetActive(false);

        
    }


    void Update()
    {
        if (correcta == false)
        {
            string correcionando = ("Respuesta incorrecta");
            correccionando.text = correcionando;

        }
        else
        {
            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //CorrecciónDivi();
            //CorrecciónMulti();
            //CorrecciónResta();
            CorrecciónSuma();
            Correccionado();
        }


    }

    public void RandomizarEnTexto()
    {
        randomnum = Random.Range(minInt, maxInt);
        randomnum2 = Random.Range(minInt, maxInt);

        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text;
        N2Text.text = n2text;
        operacion.text = "+";
    }

    public void CorrecciónSuma()
    {

        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum + randomnum2;

        if (insertRes == res)
        {
            correcta = true;

        }

        else
        {
            correcta = false;
        }
    }

    public void Correccionado()
    {
        correccionado.SetActive(true);
    }

    public GameObject Cuenta;
    public GameObject Ataque;
    public GameObject Escape;

    public void Reset()
    {
        Cuenta.SetActive(false);
        Ataque.SetActive(true);
        btnContinuar.transform.position = new Vector3(1000, 1000, 0);
        Escape.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
        Escape.transform.localPosition = new Vector3(280, -195, 0);

        //RandomizarDivi();
        RandomizarEnTexto();  
        //RandomizarResta();
        //RandomizarMulti();



        correccionado.SetActive(false);

        string textReset = ("");
        correccionando.text = textReset;

        string InputReset = "";
        Respuesta.text = InputReset;
    }


    public void RandomizarResta()
    {

        randomnum = Random.Range(maxInt, minInt);
        randomnum2 = Random.Range(randomnum, minInt);

        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text;
        N2Text.text = n2text;
        operacion.text = "-";
    }

    public void CorrecciónResta()
    {
        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum - randomnum2;

        if (insertRes == res)
        {
            correcta = true;

        }

        else
        {
            correcta = false;
        }

    }

    public void RandomizarMulti()
    {
        randomnum = Random.Range(minInt, maxInt);
        randomnum2 = Random.Range(minInt, maxInt);

        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text;
        N2Text.text = n2text;
        operacion.text = "x";

    }

    public void CorrecciónMulti()
    {
        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum * randomnum2;

        if (insertRes == res)
        {
            correcta = true;
        }

        else
        {
            correcta = false;
        }

    }

    public void RandomizarDivi()
    {
        maxInt = 50;
        minInt = 10;
        randomnum = Random.Range(maxInt, minInt);

        bool esPrimo = true;

        for (int i = 2; i < randomnum; i++)
        {

            if (randomnum % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo == true)
        {
            RandomizarDivi();
        }


        randomnum2 = Random.Range(randomnum / 2, 2);


        bool esDivisor = true;

        for (int i = 1; i < randomnum2; i++)
        {

            if (randomnum % randomnum2 == 0)
            {
                esDivisor = false;
                break;
            }
        }

        if (esDivisor == true)
        {
            RandomizarDivi();
        }


        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text;
        N2Text.text = n2text;
        operacion.text = "/";

    }

    public void CorrecciónDivi()
    {

        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum / randomnum2;

        if (insertRes == res)
        {
            correcta = true;

        }

        else
        {
            correcta = false;
        }

    }


}
