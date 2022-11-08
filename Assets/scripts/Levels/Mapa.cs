using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mapa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReinoSuma()
    {
        SceneManager.LoadScene("Reino suma");
    }
    public void Reinoresta()
    {
        SceneManager.LoadScene("Reino resta");
    }
    public void ReinoMulti()
    {
        SceneManager.LoadScene("Reino multi");
    }
    public void ReinoDivi()
    {
        SceneManager.LoadScene("Reino divi");
    }
    public void Roma()
    {
        SceneManager.LoadScene("roma");
    }
}
