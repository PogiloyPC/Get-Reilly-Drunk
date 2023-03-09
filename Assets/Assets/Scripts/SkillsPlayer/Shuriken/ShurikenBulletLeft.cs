using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenBulletLeft : MonoBehaviour
{
    public float speedBullet;
    public float damage;

    void Start()
    {

    }


    void Update()
    {
        transform.position = new Vector2(transform.position.x - speedBullet * Time.deltaTime, transform.position.y);
        Destroy(gameObject, 4f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthEnemy enemy = collision.gameObject.GetComponent<HealthEnemy>();
        EnemyShiled shiled = collision.gameObject.GetComponent<EnemyShiled>();
        if (enemy != null)
        {
            if (enemy.armor != 0)
            {
                enemy.TakeDamageArmor(1);
            }
            else
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        if (shiled != null)
        {
            Destroy(gameObject);
        }
    }
}
