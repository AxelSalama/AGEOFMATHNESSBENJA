using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NroRandom : MonoBehaviour
{

    public int NroFinal;
    public string RomaFinal;
    bool esM10;
    public TextMesh NroRomaFinal;
    public TextMesh txtopcion1;
    public TextMesh txtopcion2;
    public TextMesh txtopcion3;

    int option1;
    int option2;
    int option3;
    public int mezcla;



    void Start()
    {

        NroFinal = Random.Range(1, 20);

        Romanificar();

        MezclarOpciones();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MezclarOpciones()
    {
        mezcla = Random.Range(1, 4);
        Debug.Log(mezcla);
        option1 = Random.Range(1, 20);
        option2 = Random.Range(1, 20);
        option3 = Random.Range(1, 20);

        if (esM10 == true)
        {
            NroFinal = NroFinal + 10;
        }

        if (mezcla == 1)
        {
            option1 = NroFinal;

            if (option1 == option2)
            {
                if (NroFinal < 10)
                {
                    option2 = NroFinal + 1;
                }
                else
                {
                    option2 = NroFinal - 1;
                }
            }
            if (option1 == option3)
            {
                if (NroFinal < 10)
                {
                    option3 = NroFinal + 1;
                }
                else
                {
                    option3 = NroFinal - 1;
                }
            }

        }
        else if (mezcla == 2)
        {
            option2 = NroFinal;

            if (option2 == option1)
            {
                if (NroFinal < 10)
                {
                    option1 = NroFinal + 1;
                }
                else
                {
                    option1 = NroFinal - 1;
                }
            }
            if (option1 == option3)
            {
                if (NroFinal < 10)
                {
                    option3 = NroFinal + 1;
                }
                else
                {
                    option3 = NroFinal - 1;
                }
            }
        }
        else if (mezcla == 3)
        {
            option3 = NroFinal;

            if (option3 == option2)
            {
                if (NroFinal < 10)
                {
                    option2 = NroFinal + 1;
                }
                else
                {
                    option2 = NroFinal - 1;
                }
            }
            if (option3 == option1)
            {
                if (NroFinal < 10)
                {
                    option1 = NroFinal + 1;
                }
                else
                {
                    option1 = NroFinal - 1;
                }
            }
        }  
            
        txtopcion1.text = option1.ToString();
        txtopcion2.text = option2.ToString();
        txtopcion3.text = option3.ToString();
    }

    public void Romanificar()
    {
        if (NroFinal > 10)
        {
            NroFinal = NroFinal - 10;
            esM10 = true;
        }

        if (NroFinal <= 5)
        {
            if (NroFinal == 1)
            {
                RomaFinal = "I";
            }
            else if (NroFinal == 2)
            {
                RomaFinal = "II";
            }
            else if (NroFinal == 3)
            {
                RomaFinal = "III";
            }
            else if (NroFinal == 4)
            {
                RomaFinal = "IV";
            }
            else if (NroFinal == 5)
            {
                RomaFinal = "V";
            }
        }
        else if (NroFinal <= 10)
        {
            if (NroFinal == 6)
            {
                RomaFinal = "VI";
            }
            else if (NroFinal == 7)
            {
                RomaFinal = "VII";
            }
            else if (NroFinal == 8)
            {
                RomaFinal = "VIII";
            }
            else if (NroFinal == 9)
            {
                RomaFinal = "IX";
            }
            else if (NroFinal == 10)
            {
                RomaFinal = "X";
            }
        }
        if (esM10 == true)
        {
            NroRomaFinal.text = "X" + RomaFinal;
        }
        else
        {
            NroRomaFinal.text = RomaFinal;
        }
        Debug.Log(NroRomaFinal.text);
    }
}
