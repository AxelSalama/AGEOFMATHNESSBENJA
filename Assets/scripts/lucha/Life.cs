using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int health;
    public InputField Res;
    public Animator animOgro;
    public Animator animOgro2;
    public Animator animOgro3;
    public Animator animOgro4;
    public Animator animRey;

    public bool correcta = true;
    public GameObject player;
    public GameObject Ataque;
    public GameObject Escape;
    private bool isPressed = false;
    public Slider slider;


    public Text Cuenta1;
    public Text Cuenta2;
    public Text operacion;
    public EscenaData escenas;

    int autodamage;

    public timeAnswer timeAnswer;

    public DificultadData nivel;
     
    void Start()
    {

        if (nivel.facil == true)
        {
            health = 50;
            slider.minValue = 100;
        }
        else if (nivel.dificil == true)
        {
            health = 100;
            slider.minValue = 50;
        }
        else if (nivel.imposible == true)
        {
            health = 100;
            slider.minValue = 50;
        }

        slider.value = health + slider.minValue;
    }

    void Update()
    {
        
        if (timeAnswer.sinTime == true)
        {
            esCorrecta();
            Debug.Log(health);
            damage();
            slider.value = health + slider.minValue;

            if (health <= 0)
            {
                Die();
                slider.value = 0;
            }
        } 

        if (Input.GetKeyDown(KeyCode.Return) && isPressed == false)
        {
            esCorrecta();
            isPressed = true;

            if (correcta == false)
            {
                damage();
                slider.value = health + slider.minValue;
                Debug.Log(health);
                StartCoroutine(AtaqueEnemigo());
            }

            if (health <= 0)
            {
                Die();
                slider.value = 0;
            }
        }
    }

    void Die()
    {
        gameObject.transform.localPosition = new Vector3(1000, 1000, 123);
        CambioEscena(); 
    }

    void CambioEscena()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Lucha S")
        {
            SceneManager.LoadScene("Reino suma");
        }
        else if (sceneName == "Lucha R")
        {
            SceneManager.LoadScene("Reino resta");
        }
        else if (sceneName == "Lucha M")
        {
            SceneManager.LoadScene("Reino multi");
        }
        else if (sceneName == "Lucha D")
        {
            SceneManager.LoadScene("Reino divi");
        }
    }
    int resul;
    bool divi;

    void esCorrecta()
    {

        string N1 = Cuenta1.text;
        string N2 = Cuenta2.text;

        if (operacion.text == "x")
        {
            resul = int.Parse(N1) * int.Parse(N2);
        }
        else if (operacion.text == "+")
        {
            resul = int.Parse(N1) + int.Parse(N2);
        }
        else if (operacion.text == "-")
        {
            resul = int.Parse(N1) - int.Parse(N2);
        }
        else if (operacion.text == "/")
        {
            resul = int.Parse(N1) / int.Parse(N2);
            divi = true;
            
        }


        if (Res.text == "")
        {
            Res.text = "-1";
        }
        string Resint = Res.text;


        if (resul == int.Parse(Resint))
        {
            correcta = true;
        }
        else
        {
            correcta = false;
            if (divi == true)
            {
                resul = resul * 5;
            }
        }
       
    }
    public void damage()
    {
        StartCoroutine(AtaqueEnemigo());
        health -= resul;
        animOgro.SetBool("Ataca", true);
        animOgro2.SetBool("Ataca", true);
        animOgro3.SetBool("Ataca", true);
        animOgro4.SetBool("Ataca", true);
        animRey.SetBool("Erraste", true);
       

    }
    IEnumerator AtaqueEnemigo()
    {
        yield return new WaitForSeconds(1.5f);
        animOgro.SetBool("Ataca", false);
        animOgro2.SetBool("Ataca", false);
        animOgro3.SetBool("Ataca", false);
        animOgro4.SetBool("Ataca", false);
        animRey.SetBool("Erraste", false);
    }

    IEnumerator CambiandoEscena()
    {
        yield return new WaitForSeconds(2);
        CambioEscena();
    }
    public void Resetearbooleano()
    {
        isPressed = false;
        
    }
}
