using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManagerDivi : MonoBehaviour
{
    public GameObject EnemigoDivi1;
    public GameObject EnemigoDivi2;
    public GameObject EnemigoDivi3;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("valor") == 13)
        {
            Instantiate(EnemigoDivi1, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoDivi1.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoDivi1.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 14)
        {
            Instantiate(EnemigoDivi2, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoDivi2.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoDivi2.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 15)
        {
            Instantiate(EnemigoDivi3, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoDivi3.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoDivi3.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
