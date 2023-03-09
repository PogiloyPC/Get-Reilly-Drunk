using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGremlin : MonoBehaviour
{
    public float damageDrunkennessScale;
    [SerializeField] private HealthPlayer player;
    [SerializeField] private Transform railly;
    public float speedEnemy;
    public float impulse;
    public float damage;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (transform.position.x > railly.position.x)
        {            
            transform.localScale = new Vector3(-1f, 1f, 1f);            
        }
        else
        {           
            transform.localScale = new Vector3(1f, 1f, 1f);         
        }
        transform.position = Vector2.MoveTowards(transform.position, railly.position, speedEnemy * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        HealthPlayer player = collision.gameObject.GetComponent<HealthPlayer>();
        Rigidbody2D bodyPlayer = player.GetComponent<Rigidbody2D>();
        if (player != null)
        {
            player.TakeDamage(damage);
            if (transform.position.x < player.transform.position.x)
            {
                bodyPlayer.AddForce(transform.right * impulse, ForceMode2D.Impulse);
                bodyPlayer.AddForce(transform.up * impulse, ForceMode2D.Impulse);
            }
            else
            {
                bodyPlayer.AddForce(transform.right * -impulse, ForceMode2D.Impulse);
                bodyPlayer.AddForce(transform.up * impulse, ForceMode2D.Impulse);
            }
        }
    }
}
