using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionManager : MonoBehaviour
{
    public PotionData pocion1;
    public PotionData pocion2;
    public PotionData pocion3;
    public PotionData pocion4;
    // Start is called before the first frame update
    void Start()
    {
        if(pocion1.isgrabbed == true)
        {
            pocion1.Pota.SetActive(false);
        }
        if (pocion2.isgrabbed == true)
        {
            pocion2.Pota.SetActive(false);
        }
        if (pocion3.isgrabbed == true)
        {
            pocion3.Pota.SetActive(false);
        }
        if (pocion4.isgrabbed == true)
        {
            pocion4.Pota.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
