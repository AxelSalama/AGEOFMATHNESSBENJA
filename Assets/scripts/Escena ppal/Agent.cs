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
    public EscenaData escenas;


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
                Scene currentScene = SceneManager.GetActiveScene();

                string sceneName = currentScene.name;

                if (sceneName == "Reino suma")
                {
                    SceneManager.LoadScene("Lucha S");
                }
                else if (sceneName == "Reino resta")
                {
                    SceneManager.LoadScene("Lucha R");
                }
                else if (sceneName == "Reino multi")
                {
                    SceneManager.LoadScene("Lucha M");
                }
                else if (sceneName == "Reino divi")
                {
                    SceneManager.LoadScene("Lucha D");
                }

                agente.speed = 0;
                Debug.Log("Estas cerca");
            }
        }
    }


}
