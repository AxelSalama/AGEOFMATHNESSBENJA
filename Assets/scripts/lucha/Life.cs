using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int health = 40;
    public InputField Res;

    public bool correcta;
    public GameObject player;
    public GameObject Heal;
    public GameObject Object;
    public GameObject Ataque;
    public GameObject Escape;
    private bool isPressed = false;
    public Slider slider;


    public Text Cuenta1;
    public Text Cuenta2;
    public Text operacion;

    int autodamage;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return) && isPressed == false)
        {
            esCorrecta();
            isPressed = true;

            if (correcta == false)
            {
                damage();
                slider.value = health;
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
        StartCoroutine(CambiandoEscena());
        
    }

    void CambioEscena()
    {
        SceneManager.LoadScene("Reino multi");
    }
    int resul;

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
        }

        string Resint = Res.text;

        if (resul == int.Parse(Resint))
        {
            correcta = true;
        }
        else
        {
            correcta = false;
        }

    }
    public void damage()
    {
        StartCoroutine(AtaqueEnemigo());
        health -= resul;
        Debug.Log(health);
        
    }
    IEnumerator AtaqueEnemigo()
    {

        Heal.GetComponent<Button>().interactable = false;
        Ataque.GetComponent<Button>().interactable = false;
        Object.GetComponent<Button>().interactable = false;
        Escape.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(1);
        Debug.Log("Perdiste vida");
        yield return new WaitForSeconds(1);
        Debug.Log("volves a tener el control");
        Heal.GetComponent<Button>().interactable = true;
        Ataque.GetComponent<Button>().interactable = true;
        Object.GetComponent<Button>().interactable = true;
        Escape.GetComponent<Button>().interactable = true;
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
