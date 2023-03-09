using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageEnamy : MonoBehaviour
{
    [SerializeField] private CriticleHit crit;
    Animator anim;
    public float damage;
    private float damageCount;
    public float damageArmor;
    private float damageArmorCount;
    private UnityEngine.Object bloodParticles;

    private void Start()
    {
        anim = GetComponent<Animator>();
        damageCount = damage;
        damageArmorCount = damageArmor;
        bloodParticles = Resources.Load("BloodParticles");
    }

    private void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthEnemy health = collision.gameObject.GetComponent<HealthEnemy>();
        EnemyShiled shiled = collision.gameObject.GetComponent<EnemyShiled>();
        if (shiled != null)
        {            
            if (transform.localScale == new Vector3(1f, 1f, 1f))
            {
                anim.SetTrigger("rebound");                
            }
            if (transform.localScale == new Vector3(-1f, 1f, 1f))
            {
                anim.SetTrigger("rebound1");                
            }
        }
        else
        {
            if (health != null)
            {                
                crit.CriticleAttack();                
                if (crit.chance == 4)
                {
                    if (health.armor != 0)
                    {
                        health.TakeDamageArmor(damageArmor * 2f);
                    }
                    else
                    {
                        GameObject bloodParticlesPref = (GameObject)Instantiate(bloodParticles);
                        bloodParticlesPref.transform.position = new Vector3(health.transform.position.x, health.transform.position.y, health.transform.position.z - 0.44f);
                        health.TakeDamage(damage * 2f);
                    }
                    Time.timeScale = 0.5f;
                }
                else
                {
                    if (health.armor != 0)
                    {
                        health.TakeDamageArmor(damageArmor);
                    }
                    else
                    {
                        health.TakeDamage(damage);
                    }
                }
            }
        }
    }    
}
