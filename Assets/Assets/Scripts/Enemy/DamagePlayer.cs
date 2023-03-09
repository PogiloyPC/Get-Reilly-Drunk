using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{    
    public float damage;

    void Start()
    {        
    }
    
    void Update()
    {        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthPlayer player = collision.GetComponent<HealthPlayer>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }
}
