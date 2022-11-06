using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogobox;
    public Movement movimiento;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            dialogobox.SetActive(true);
            movimiento.velocidadMovimiento = 0f;
            movimiento.velocidadRotacion = 0f;
            movimiento.fuerzaDeSalto = 0f;
        }

    }
}
