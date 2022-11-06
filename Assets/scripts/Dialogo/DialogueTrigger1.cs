using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue dialogo;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogo.PasaronCosas == true)
        {
            SceneManager.LoadScene("Reino suma");
        }
    }
}
