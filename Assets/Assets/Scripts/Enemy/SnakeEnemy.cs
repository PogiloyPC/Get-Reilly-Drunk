using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeEnemy : MonoBehaviour
{
    [SerializeField] public Transform railly;
    public float poison;
    public float speedSnake;
    public bool comeBackDrunkennessSpeed;
    private HealthEnemy healthEnemy;

    void Start()
    {
        healthEnemy = GetComponent<HealthEnemy>();
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, railly.position, speedSnake * Time.deltaTime);
        if (transform.position.x > railly.position.x)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        DrunkennessScale railly = collision.gameObject.GetComponent<DrunkennessScale>();
        if (railly != null)
        {
            railly.soberingSpeed += poison;
            comeBackDrunkennessSpeed = true;
        }
    }
}
