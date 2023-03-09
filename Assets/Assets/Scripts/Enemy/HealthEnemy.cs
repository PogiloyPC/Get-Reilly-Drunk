using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public float startHealth;
    public float currentHealth;
    public float armor;
    public int minMoneyCount;
    public int maxMoneyCount;    
    [SerializeField] private SnakeEnemy snake;
    [SerializeField] private MoneyCount money;
    [SerializeField] private GameObject drink;
    
    void Start()
    {        
        currentHealth = startHealth;        
    }

    
    void Update()
    {
        if (armor == 0)
        {
            if (currentHealth <= 0f)
            {
                int figure = Random.Range(0, 20);
                money.countMoney = Random.Range(minMoneyCount, maxMoneyCount);
                Instantiate(money.gameObject, transform.position, Quaternion.identity);
                if (figure == 4)
                {
                    Instantiate(drink, transform.position, Quaternion.identity);
                }                  
                Destroy(gameObject);
            }
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startHealth);
    }

    public void TakeDamageArmor(float damageArmor)
    {
        armor = Mathf.Clamp(armor - damageArmor, 0, armor);
    }
}
