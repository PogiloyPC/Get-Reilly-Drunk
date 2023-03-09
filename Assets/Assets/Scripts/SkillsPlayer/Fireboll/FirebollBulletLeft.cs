using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebollBulletLeft : MonoBehaviour
{
    public float speedBullet;
    public float damage;
    private UnityEngine.Object fireParticles;

    void Start()
    {
        fireParticles = Resources.Load("FireParticles");
    }

    void Update()
    {
        GameObject fireParticlesPref = (GameObject)Instantiate(fireParticles);
        fireParticlesPref.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.44f);
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
                enemy.TakeDamageArmor(damage);
            }
            else
            {
                enemy.TakeDamage(damage);
            }
        }
        if (shiled != null)
        {
            Destroy(gameObject);
        }
    }
}
