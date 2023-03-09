using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenAttack : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform shotPos;
    [SerializeField] private GameObject shurikenBulletRight;
    [SerializeField] private GameObject shurikenBulletLeft;
    public float countShuriken;
    private float countShurikenFinish;
    public float timerShotStart;
    private float timerShotFinish;
    public bool recharge;

    void Start()
    {
        countShurikenFinish = countShuriken;        
    }
    
    void Update()
    {
        if (countShurikenFinish > 0f)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (player.localScale == new Vector3(1f, 1f, 1f))
                {
                    Instantiate(shurikenBulletRight, shotPos.position, Quaternion.identity);
                }
                if (player.localScale == new Vector3(-1f, 1f, 1f))
                {
                    Instantiate(shurikenBulletLeft, shotPos.position, Quaternion.identity);
                }
                countShurikenFinish -= 1f;
            }
        }
        if (countShurikenFinish == 0f && recharge == false)
        {
            timerShotFinish = timerShotStart;
            recharge = true;
        }
        if (recharge == true)
        {
            if (timerShotFinish >= 0f)
            {
                timerShotFinish -= 1f * Time.deltaTime;
            }
            else
            {
                countShurikenFinish = countShuriken;
                recharge = false;
            }
        }        
    }
}
