using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingPlayer : MonoBehaviour
{
    [Header("PlayerRate")]
    [SerializeField] private GameObject shop;
    public float speed;
    public float jump;
    public float spawnTime;    
    [SerializeField] public ForceMode2D mode;
    [SerializeField] Rigidbody2D heroBody;
    [SerializeField] public GameObject playerClone;
    [Header("AttackPlayer")]    
    public bool attack;
    public float startSpeedRotationWeapon;
    private float finishSpeedRotationWeapon;
    [SerializeField] public GameObject[] weapon;
    [SerializeField] private Transform posWeapon;
    [SerializeField] private float colliderDistanceAttack;
    private RaycastHit2D[] rayAttack;
    public int countRayAttack;
    public float XYdistance;
    public float rayDistanceAttack;
    public float rayDistanceYAttack;
    Animator animWeapon;
    [Header("CheckGround")]
    private RaycastHit2D ray;
    public float rayDistance;
    public float rayDistanceY;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private float colliderDistance;
    [Header("ScoreMoney")]
    [SerializeField] Text scoreMoney;
    public int countMoney;    
    [SerializeField] public GameObject[] enemy;
    [Header("PlayerSkills")]
    [SerializeField] public GameObject[] skills;

    void Start()
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            if (i == 0)
            {
                weapon[i].SetActive(true);
                animWeapon = weapon[i].GetComponent<Animator>();
            }
            else
            {
                skills[i].SetActive(false);
                weapon[i].SetActive(false);
            }            
        }
        rayAttack = new RaycastHit2D[countRayAttack];
    }
    
    void Update()
    {
        scoreMoney.text = countMoney.ToString();
        ray = Physics2D.BoxCast(boxCollider.bounds.center + transform.up * rayDistanceY * transform.localScale.y * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z),
        0, Vector2.left, 0, LayerMask.GetMask("Ground"));        
        if (ray.collider == null)
        {
            heroBody.gravityScale += 3f * Time.deltaTime;
        }
        else
        {
            heroBody.gravityScale = 1f;
        }
        for (int i = 0; i < weapon.Length; i++)
        {     
            if (weapon[i].activeSelf == true)
            {
                animWeapon = weapon[i].GetComponent<Animator>();
            }
            weapon[i].transform.position = posWeapon.position;            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
            transform.localScale = new Vector3(1, 1, 1);
            for (int i = 0; i < weapon.Length; i++)
            {
                weapon[i].transform.localScale = new Vector3(1, 1, 1);            
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            transform.localScale = new Vector3(-1, 1, 1);
            for (int i = 0; i < weapon.Length; i++)
            {
                weapon[i].transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }        
        if (Input.GetKeyDown(KeyCode.Mouse0) && shop.activeSelf == false)
        {            
            if (transform.localScale == new Vector3(1, 1, 1))
            {
                animWeapon.SetTrigger("attack");
            }
            if (transform.localScale == new Vector3(-1, 1, 1))
            {
                animWeapon.SetTrigger("attack1");
            }            
        }        
    }

    public void Jump()
    {
        if (ray.collider.gameObject != null)
        {            
            heroBody.AddForce(transform.up * jump, mode);
        }                            
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(boxCollider.bounds.center + transform.up * rayDistanceY * transform.localScale.y * colliderDistance,
        new Vector3(boxCollider.bounds.size.x * rayDistance, boxCollider.bounds.size.y * rayDistanceY, boxCollider.bounds.size.z));
    }   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        MoneyCount quantityMoney = collision.gameObject.GetComponent<MoneyCount>();
        if (quantityMoney != null)
        {            
            countMoney += quantityMoney.countMoney;
            Destroy(collision.gameObject);
        }
    }
}
