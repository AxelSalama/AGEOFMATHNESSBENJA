using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    //public Transform SpawnerPoint;
    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    public EnemyData ogro;
    public EnemyData duende;
    public EnemyData elfo;
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
    }

    
    void Update()
    {
        
    }
}
