using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebollRight : MonoBehaviour
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
        transform.position = new Vector2(transform.position.x + speedBullet * Time.deltaTime, transform.position.y);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthPlayer player = collision.gameObject.GetComponent<HealthPlayer>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
