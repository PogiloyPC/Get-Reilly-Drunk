using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirbollAttack : MonoBehaviour
{
    [SerializeField] public GameObject fireBulletRight;
    [SerializeField] public GameObject fireBulletLeft;
    [SerializeField] public Transform weaponPos;
    [SerializeField] public GameObject player;
    public float timerStartAttack;
    private float timerFinishAttack;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (timerFinishAttack <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (player.transform.localScale == new Vector3(1f, 1f, 1f))
                {
                    Instantiate(fireBulletRight, weaponPos.position, Quaternion.identity);
                }
                if (player.transform.localScale == new Vector3(-1f, 1f, 1f))
                {
                    Instantiate(fireBulletLeft, weaponPos.position, Quaternion.identity);
                }
                timerFinishAttack = timerStartAttack;
            }
        }
        else
        {
            timerFinishAttack -= 1f * Time.deltaTime;
        }
    }
}
