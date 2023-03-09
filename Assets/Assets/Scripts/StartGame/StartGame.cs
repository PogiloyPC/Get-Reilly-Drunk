using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{   

    public void StartScene()
    {        
        SceneManager.LoadScene("GameScene");        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
