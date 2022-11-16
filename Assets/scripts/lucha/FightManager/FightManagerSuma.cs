using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManagerSuma : MonoBehaviour
{
    public GameObject Duende;
    public GameObject Duende2;
    public GameObject Duende3;
    public GameObject Duende4;
    public GameObject Duendecin1;
    public GameObject Duendecin2;
    public GameObject Duendecin3;
    public GameObject Duendecin4;
    void Update()
    {
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            Duende.transform.position = new Vector3(14, 6, 9);
            //Instantiate(Duende, new Vector3(14, 6, 9), Quaternion.identity);
            //Duendecin1.transform.eulerAngles = new Vector3(0, -90, 0);
            //Duende.transform.localScale = new Vector3(1, 1, 1);
            
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            Duende2.transform.position = new Vector3(14, 7, 9);
            //Instantiate(Duende2, new Vector3(14, 6, 9), Quaternion.identity);
            //Duendecin2.transform.eulerAngles = new Vector3(0, -90, 0);
            //Duende2.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            Duende3.transform.position = new Vector3(14, 0, 9);
            //Instantiate(Duende3, new Vector3(14, 6, 9), Quaternion.identity);
            //Duendecin3.transform.eulerAngles = new Vector3(0, -90, 0);
            //Duende3.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 4)
        {
            Duende4.transform.position = new Vector3(14, 0, 9);
        }
    }
}
