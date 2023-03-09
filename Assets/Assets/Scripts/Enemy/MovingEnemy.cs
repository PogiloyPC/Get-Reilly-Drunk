using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public float damageDrunkennessScale;
    [SerializeField] private HealthPlayer player;
    [SerializeField] private Transform railly;
    public float speedEnemy;
    [Header("Attack")]
    [SerializeField] private Transform posWeapon;
    [SerializeField] private GameObject weapon;
    [SerializeField] Animator animWeapon;
    private bool attack;
    public bool attackWeapon;
    public float distanceWeapon;
    public float startTimer;
    private float finishTimer;
    [Header("RaycastHit2D")]
    private RaycastHit2D ray;
    public float rayDistance;
    public float rayDistanceY;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private float colliderDistance;
    [Header("Ronin")]
    private RaycastHit2D ray2;
    public float roll;
    public float rayDistance2;
    public float rayDistanceY2;
    public float timerStartRoll;
    public bool roninAttack;
    private float timerFinishRoll;
    [SerializeField] private BoxCollider2D boxCollider2;
    [SerializeField] private float colliderDistance2;
    [Header("ArmorEnemy")]
    public bool armorEnemy;
    public float distanceHelmet;
    public float impulseArmor;
    [SerializeField] public GameObject jacketArmor;
    [SerializeField] public GameObject helmetArmor;
    [Header("enemyShiled")]
    [SerializeField] private GameObject shiled;
    public bool shiledEnemy;
    public float shiledDistance;

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
            weapon.transform.localScale = new Vector3(-1f, 1f, 1f);           
            shiledDistance = -0.78f;            
        }
        else
        {
            posWeapon.transform.position = new Vector2(transform.position.x + distanceWeapon, transform.position.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
            weapon.transform.localScale = new Vector3(1f, 1f, 1f);           
            shiledDistance = 0.78f;            
        }
        if (attackWeapon == true)
        {
            if (ray.collider != null)
            {
                attack = true;
                Rigidbody2D body = GetComponent<Rigidbody2D>();
                body.velocity = new Vector2(0f, 0f);
            }
            else
            {
                attack = false;            
            }
        }
        if (attack == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, railly.position, speedEnemy * Time.deltaTime);
        }
        else
        {
            if (finishTimer <= 0f)
            {
                if (transform.position.x > railly.position.x)
                {
                    animWeapon.SetTrigger("attack");
                }
                else
                {
                    animWeapon.SetTrigger("attack");
                }
                finishTimer = startTimer;
            }
            else
            {
                finishTimer -= 1f * Time.deltaTime;
            }
        }
        if (roninAttack == true)
        {
            RoninAttack();
        }
        if (armorEnemy == true)
        {
            ArmorEnemy();
        }
        /*if (shiledEnemy == true)
        {
            ShiledEnemy();
        }*/
    }
        
    public void RoninAttack()
    {    
        ray2 = Physics2D.BoxCast(boxCollider2.bounds.center + transform.right * rayDistance2 * transform.localScale.x * colliderDistance2,
        new Vector3(boxCollider2.bounds.size.x * rayDistance2, boxCollider2.bounds.size.y * rayDistanceY2, boxCollider2.bounds.size.z),
        0, Vector2.left, 0, LayerMask.GetMask("Player"));
        if (ray2.collider != null)
        {
            if (timerFinishRoll <= 0f)
            {
                if (transform.position.x > railly.position.x)
                {
                    Rigidbody2D body = GetComponent<Rigidbody2D>();
                    body.AddForce(transform.right * -roll, ForceMode2D.Impulse);
                }
                else
                {
                    Rigidbody2D body = GetComponent<Rigidbody2D>();
                    body.AddForce(transform.right * roll, ForceMode2D.Impulse);
                }
                timerFinishRoll = timerStartRoll;
            }
            else
            {
                timerFinishRoll -= 1f * Time.deltaTime;
            }
        }
    }

    public void ArmorEnemy()
    {
        helmetArmor.SetActive(true);
        jacketArmor.SetActive(true);
        HealthEnemy health = GetComponent<HealthEnemy>();
        if (health.armor == 2)
        {
            helmetArmor.transform.position = new Vector2(transform.position.x, transform.position.y + distanceHelmet);
            jacketArmor.transform.position = new Vector3(transform.position.x, transform.position.y, -0.33f);
        }
        else if (health.armor == 1)
        {
            jacketArmor.transform.position = new Vector3(transform.position.x, transform.position.y, -0.33f);
            Rigidbody2D helmet = helmetArmor.GetComponent<Rigidbody2D>();
            helmet.gravityScale = 1f;                        
        }
        else if (health.armor == 0)
        {
            Rigidbody2D jacket = jacketArmor.GetComponent<Rigidbody2D>();
            jacket.gravityScale = 1f;           
        }
    }

    /*public void ShiledEnemy()
    {
        shiled.SetActive(true);
        weapon.SetActive(false);
        shiled.transform.position = new Vector2(transform.position.x + shiledDistance, transform.position.y);
    }*/

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(boxCollider.bounds.center + transform.right * rayDistance * transform.localScale.x * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z));
        Gizmos.DrawCube(boxCollider2.bounds.center + transform.right * rayDistance2 * transform.localScale.x * colliderDistance2,
        new Vector3(boxCollider2.bounds.size.x * rayDistance2, boxCollider2.bounds.size.y * rayDistanceY2, boxCollider2.bounds.size.z));
    }    
}
