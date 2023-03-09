using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveShopSistem : MonoBehaviour
{
    [SerializeField] private GameObject phrases;
    [SerializeField] private GameObject shopSistem;
    [SerializeField] public GameObject[] shopSlot;
    public bool pauseGame;

    void Start()
    {
        shopSistem.SetActive(false);
        for (int i = 0; i < shopSlot.Length; i++)
        {
            if (i == 0)
            {
                shopSlot[i].SetActive(true);
            }
            else
            {
                shopSlot[i].SetActive(false);
            }
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (pauseGame == false)
            {
                phrases.SetActive(false);
                shopSistem.SetActive(true);
                PauseGame();
            }
            else
            {
                shopSistem.SetActive(false);
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseGame = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseGame = false;
    }
}
