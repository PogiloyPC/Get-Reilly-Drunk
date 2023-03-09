using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private Image healthPlayer;
    [SerializeField] private GameObject gameOver;
    public float startHealth;
    private float currentHealth;

    void Start()
    {
        currentHealth = startHealth;
    }
    
    void Update()
    {
        if (currentHealth <= 0f)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }

        healthPlayer.fillAmount = currentHealth / startHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0f, startHealth);
    }
}
