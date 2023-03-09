using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShiled : MonoBehaviour
{
    public float impulse;
    private RaycastHit2D ray;
    public float rayDistance;
    public float rayDistanceY;
    [SerializeField] private Transform railly;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private float colliderDistance;

    void Start()
    {
        
    }

    
    void Update()
    {
        ray = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * rayDistance * transform.localScale.x * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z),
        0, Vector2.left, 0);
        TakeDamageEnamy sword = ray.collider.gameObject.GetComponent<TakeDamageEnamy>();
        if (sword != null)
        {
            sword.damage = 0f;
            sword.damageArmor = 0f;
        }        
        if (transform.position.x > railly.position.x)
        {
            colliderDistance = -0.11f;
        }
        else
        {
            colliderDistance = 0.11f;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        HealthPlayer player = collision.gameObject.GetComponent<HealthPlayer>();
        Rigidbody2D bodyPlayer = player.GetComponent<Rigidbody2D>();
        if (player != null)
        {
            player.TakeDamage(1);
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

    /*public void OnCollisionStay2D(Collision2D collision)
    {
        HealthPlayer player = collision.gameObject.GetComponent<HealthPlayer>();
        Rigidbody2D bodyPlayer = player.GetComponent<Rigidbody2D>();
        if (player != null)
        {
            player.TakeDamage(1);
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
    }*/

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawCube(boxCollider.bounds.center + transform.right * rayDistance * transform.localScale.x * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z));
    }
}
