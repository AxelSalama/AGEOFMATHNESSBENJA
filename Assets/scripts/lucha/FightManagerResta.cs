using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManagerResta : MonoBehaviour
{
    public GameObject EnemigoResta1;
    public GameObject EnemigoResta2;
    public GameObject EnemigoResta3;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("valor")== 7)
        {
            Instantiate(EnemigoResta1, new Vector3(15, 0, 15), Quaternion.identity);
            EnemigoResta1.transform.eulerAngles = new Vector3(0, 0, 0);
            EnemigoResta1.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 8)
        {
            Instantiate(EnemigoResta2, new Vector3(15, 0, 15), Quaternion.identity);
            EnemigoResta2.transform.eulerAngles = new Vector3(0, 0, 0);
            EnemigoResta2.transform.localScale = new Vector3(1, 1, 1);
        }
        if (PlayerPrefs.GetInt("valor") == 9)
        {
            Instantiate(EnemigoResta2, new Vector3(15, 0, 15), Quaternion.identity);
            EnemigoResta2.transform.eulerAngles = new Vector3(0, 0, 0);
            EnemigoResta2.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
