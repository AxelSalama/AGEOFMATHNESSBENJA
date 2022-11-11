using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene : MonoBehaviour
{
    


    public void Volver()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Lucha S")
        {
            SceneManager.LoadScene("Reino suma");
        }
        else if (sceneName == "Lucha R")
        {
            SceneManager.LoadScene("Reino resta");
        }
        else if (sceneName == "Lucha M")
        {
            SceneManager.LoadScene("Reino multi");
        }
        else if (sceneName == "Lucha D")
        {
            SceneManager.LoadScene("Reino divi");
        }
    }
}
 