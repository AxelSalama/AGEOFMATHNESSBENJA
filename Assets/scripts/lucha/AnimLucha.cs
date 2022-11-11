using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimLucha : MonoBehaviour
{
    public Animator anim;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("tocoSuelo", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
