using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    public GameObject Duende2;
    public EnemyData ogro;
    public EnemyData duende;
    public EnemyData elfo;
    public EnemyData duende2;
    public EnemyLife enemylife;
    void Start()
    {
        
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            Instantiate(Duende, new Vector3(14, 0, 14), Quaternion.identity);
            Duende.transform.eulerAngles = new Vector3(0, -90, 0);
            Duende.transform.localScale = new Vector3(1, 1, 1);
            
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            Instantiate(Elfo, new Vector3(14, 0, 14), Quaternion.identity);
            Elfo.transform.eulerAngles = new Vector3(0, -90, 0);
            Elfo.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            Instantiate(Ogro, new Vector3(14, 0, 14), Quaternion.identity);
            Ogro.transform.eulerAngles = new Vector3(0, -90, 0);
            Ogro.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 4)
        {
            Instantiate(Duende2, new Vector3(14, 0, 14), Quaternion.identity);
            Duende2.transform.eulerAngles = new Vector3(0, -90, 0);
            Duende2.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
