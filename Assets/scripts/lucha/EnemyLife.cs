using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnemyLife : MonoBehaviour
{
    public int health;
    public EnemyData datosenemigos;
    public GameObject enemyPrefab;
    public InputField Res;
    public Animator animJugador;
    int daño;
    string dañop;

    public bool correcta;
   
    public Text Cuenta1;
    public Text Cuenta2;
    public Text operacion;
    private string N1;
    private string N2;
    public bool isPressed;
    public Slider slider;

    public GameObject Duende;
    public GameObject Duende2;
    public GameObject Duende3;
    public GameObject Duende4;
    public GameObject Rey;
    public GameObject EnemigoResta1;
    public GameObject EnemigoResta2;
    public GameObject EnemigoResta3;
    public GameObject EnemigoMulti1;
    public GameObject EnemigoMulti2;
    public GameObject EnemigoMulti3;
    public GameObject EnemigoDivi1;
    public GameObject EnemigoDivi2;
    public GameObject EnemigoDivi3;
    public EnemyData duende;
    public EnemyData duende2;
    public EnemyData duende3;
    public EnemyData duende4;
    public EnemyData rey;
    public EnemyData enemigoresta1;
    public EnemyData enemigoresta2;
    public EnemyData enemigoresta3;
    public EnemyData enemigomulti1;
    public EnemyData enemigomulti2;
    public EnemyData enemigomulti3;
    public EnemyData enemigodivi1;
    public EnemyData enemigodivi2;
    public EnemyData enemigodivi3;

    public DificultadData nivel;

    public void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Lucha M")
        {
            datosenemigos = rey;
            enemyPrefab = Rey;
        }
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            datosenemigos = duende;
            enemyPrefab = Duende;
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            datosenemigos = duende2;
            enemyPrefab = Duende2;
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            datosenemigos = duende3;
            enemyPrefab = Duende3;
        }
        if (PlayerPrefs.GetInt("valor") == 4)
        {
            datosenemigos = duende4;
            enemyPrefab = Duende4;
        }
        if(PlayerPrefs.GetInt("valor") == 6)
        {
            datosenemigos = rey;
            enemyPrefab = Rey;
        }
        if (PlayerPrefs.GetInt("valor") == 7)
        {
            datosenemigos = enemigoresta1;
            enemyPrefab = EnemigoResta1;
        }
        if (PlayerPrefs.GetInt("valor") == 8)
        {
            datosenemigos = enemigoresta2;
            enemyPrefab = EnemigoResta2;
        }
        if (PlayerPrefs.GetInt("valor") == 9)
        {
            datosenemigos = enemigoresta3;
            enemyPrefab = EnemigoResta3;
        }
        if (PlayerPrefs.GetInt("valor") == 10)
        {
            datosenemigos = enemigomulti1;
            enemyPrefab = EnemigoMulti1;
        }
        if (PlayerPrefs.GetInt("valor") == 11)
        {
            datosenemigos = enemigomulti2;
            enemyPrefab = EnemigoMulti2;
        }
        if (PlayerPrefs.GetInt("valor") == 12)
        {
            datosenemigos = enemigomulti3;
            enemyPrefab = EnemigoMulti3;
        }
        if (PlayerPrefs.GetInt("valor") == 13)
        {
            datosenemigos = enemigodivi1;
            enemyPrefab = EnemigoDivi1;
        }
        if (PlayerPrefs.GetInt("valor") == 14)
        {
            datosenemigos = enemigodivi2;
            enemyPrefab = EnemigoDivi2;
        }
        if (PlayerPrefs.GetInt("valor") == 15)
        {
            datosenemigos = enemigodivi3;
            enemyPrefab = EnemigoDivi3;
        }
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


    public void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Return) && isPressed == false)
        {

            esCorrecta();
            isPressed = true;
            

            if (correcta == true)
            {
                damage();
                slider.value = health + slider.minValue;
                correcta = false;
                StartCoroutine(AtaqueJugador());
            }

            if (health <= 0)
            {
                Die();
                slider.value = 0;
            }
        }
    }

    public void damage()
    {
        //dañop = Res.text;
        //daño = int.Parse(dañop);
        daño = resul;
        health -= daño;
        animJugador.SetBool("Atacaste", true);
    }

    void Die()
    {
        datosenemigos.derrotado = true;
        DestroyImmediate(enemyPrefab, true);
        CambioEscena();
    }
    IEnumerator AtaqueJugador()
    {
        yield return new WaitForSeconds(1.5f);
        animJugador.SetBool("Atacaste", false);
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
        else if (sceneName == "Lucha rey")
        {
            SceneManager.LoadScene("Reino resta");
        }
    }
    int resul;
    bool divi;
    public void esCorrecta()
    {
        N1 = Cuenta1.text;
        N2 = Cuenta2.text;
        Res.GetComponent<InputField>().interactable = false;

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
        string Resint = Res.text;

        if (resul == int.Parse(Resint))
        {
            correcta = true;
            if (divi == true)
            {
                resul = resul * 5;
            }
        }
        else
        {
            correcta = false;

        }
     
    }
    public void reseteoBool()
    {
        isPressed = false;
    }
}