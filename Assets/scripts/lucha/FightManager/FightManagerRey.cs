using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManagerRey : MonoBehaviour
{
    public GameObject Rey;
    public EnemyData rey;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("valor", 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
