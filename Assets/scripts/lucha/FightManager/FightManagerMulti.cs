using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManagerMulti : MonoBehaviour
{
    public GameObject EnemigoMulti1;
    public GameObject EnemigoMulti2;
    public GameObject EnemigoMulti3;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("valor") == 10)
        {
            Instantiate(EnemigoMulti1, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoMulti1.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoMulti1.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 11)
        {
            Instantiate(EnemigoMulti2, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoMulti2.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoMulti2.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 12)
        {
            Instantiate(EnemigoMulti3, new Vector3(16, 0, 23), Quaternion.identity);
            EnemigoMulti3.transform.eulerAngles = new Vector3(0, -90, 0);
            EnemigoMulti3.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
