using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Agent : MonoBehaviour
{
    public Transform destinationTransform;
    public NavMeshAgent agente;
    public Animator anim;
    public float DistanceToPlayer;
    
    
    void Start()
    {
        agente.speed = 0;
        anim.SetBool("Idle", true);
    }
    
    void Update()
    {
        agente.destination = destinationTransform.position;
        DistanceToPlayer = agente.remainingDistance;
    }


    void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            agente.speed = 25;
            anim.SetBool("Idle", false);

            if (agente.remainingDistance < 10)
            {
                SceneManager.LoadScene("Lucha M");
                Debug.Log("Esta cerca el enemigo");
                agente.speed = 0;
                
            }
        }
    }


}
