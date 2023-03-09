using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonEnemy : MonoBehaviour
{
    public float damageDrunkennessScale;
    [SerializeField] private HealthPlayer player;
    [SerializeField] private Transform railly;
    public float speedEnemy;
    [Header("Attack")]
    [SerializeField] private Transform posWeapon;
    [SerializeField] private GameObject firebollRight;
    [SerializeField] private GameObject firebollLeft;    
    private bool attack;    
    public float distanceWeapon;    
    [Header("RaycastHit2D")]
    private RaycastHit2D ray;
    public float rayDistance;
    public float rayDistanceY;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private float colliderDistance;

    void Start()
    {

    }

    void Update()
    {
        ray = Physics2D.BoxCast(boxCollider.bounds.center + transform.right * rayDistance * transform.localScale.x * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z),
        0, Vector2.left, 0, LayerMask.GetMask("Player"));
        if (transform.position.x > railly.position.x)
        {
            posWeapon.transform.position = new Vector2(transform.position.x - distanceWeapon, transform.position.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);                      
        }
        else
        {
            posWeapon.transform.position = new Vector2(transform.position.x + distanceWeapon, transform.position.y);
            transform.localScale = new Vector3(1f, 1f, 1f);             
        }        
        if (ray.collider != null)
        {
            attack = true;                
        }
        else
        {
            attack = false;
        }        
        if (attack == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, railly.position, speedEnemy * Time.deltaTime);
        }
        else
        {
            
            if (transform.position.x > railly.position.x)
            {                
                Instantiate(firebollLeft, posWeapon.position, Quaternion.identity);                
            }
            else
            {
                Instantiate(firebollRight, posWeapon.position, Quaternion.identity);
            }
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(boxCollider.bounds.center + transform.right * rayDistance * transform.localScale.x * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z));
    }
}
