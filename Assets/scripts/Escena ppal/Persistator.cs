using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistator : MonoBehaviour
{
    public static Persistator instance;
    public GameObject jugador;
    public Movement movement;
    public Vector3 PosicionFinal;
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        PosicionFinal = jugador.transform.position;
    }
}
