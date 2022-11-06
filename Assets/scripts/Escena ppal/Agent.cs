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
    public float DistanceToPLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        agente.speed = 0;
        anim.SetBool("Idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = destinationTransform.position;
        DistanceToPLayer = Vector3.Distance(transform.position, destinationTransform.position);
    }


    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            agente.speed = 25;
            anim.SetBool("Idle", false);

            if (Vector3.Distance(transform.position, destinationTransform.position) < 3)
            {
                SceneManager.LoadScene("Lucha M");
                Debug.Log("Esta cerca el enemigo");
                agente.speed = 0;
                
            }
        }
    }


}
