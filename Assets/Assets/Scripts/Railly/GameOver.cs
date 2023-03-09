using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        MovingEnemy enemy = collision.GetComponent<MovingEnemy>();
        if (enemy != null)
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

