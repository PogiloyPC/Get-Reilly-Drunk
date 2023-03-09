using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloneMove : MonoBehaviour
{
    private GameObject player;
    public Vector2 difference;
    public float speedJerkWithAttack;
    private UnityEngine.Object bloodParticles;

    void Start()
    {
        player = GameObject.Find("Hero");
        bloodParticles = Resources.Load("BloodParticles");
    }
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, difference, speedJerkWithAttack * Time.deltaTime);
        if (transform.position.x == difference.x)
        {
            //player.SetActive(true);
            player.transform.position = transform.position;
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        HealthEnemy enemy = collision.gameObject.GetComponent<HealthEnemy>();        
        if (enemy != null)
        {
            if (enemy.armor != 0)
            {
                GameObject bloodParticlesPref = (GameObject)Instantiate(bloodParticles);
                bloodParticlesPref.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z - 0.44f);
                enemy.TakeDamageArmor(30);
                enemy.TakeDamage(30);
            }
            else
            {
                GameObject bloodParticlesPref = (GameObject)Instantiate(bloodParticles);
                bloodParticlesPref.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z - 0.44f);
                enemy.TakeDamage(30);                        
            }
        }        
    }
}
