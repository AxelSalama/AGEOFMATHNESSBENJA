using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigo : MonoBehaviour
{
    public EnemyData enemydata;

    private void Start()
    {
        if(enemydata.derrotado == true)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("valor", GetComponent<enemigo>().enemydata.orden);
            //SceneManager.LoadScene("Lucha");
        }
    }
}
