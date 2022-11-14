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

    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    public GameObject Duende2;
    public GameObject Rey;
    public GameObject EnemigoResta1;
    public GameObject EnemigoResta2;
    public GameObject EnemigoResta3;
    public EnemyData ogro;
    public EnemyData duende;
    public EnemyData duende2;
    public EnemyData elfo;
    public EnemyData rey;
    public EnemyData enemigoresta1;
    public EnemyData enemigoresta2;
    public EnemyData enemigoresta3;

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
            datosenemigos = elfo;
            enemyPrefab = Elfo;
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            datosenemigos = ogro;
            enemyPrefab = Ogro;
        }
        if (PlayerPrefs.GetInt("valor") == 4)
        {
            datosenemigos = duende2;
            enemyPrefab = Duende2;
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
        
    }

    void Die()
    {
        datosenemigos.derrotado = true;
        DestroyImmediate(enemyPrefab, true);
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