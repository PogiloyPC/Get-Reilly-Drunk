using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    public ForceMode2D mode;
    public float rollImpulse;
    public float timerStartRoll;
    private float timerFinishRoll;
    public bool stopRoll;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (player.gameObject.transform.localScale == new Vector3(1, 1, 1))
            {
                player.AddForce(transform.right * rollImpulse, mode);
            }
            if (player.gameObject.transform.localScale == new Vector3(-1, 1, 1))
            {
                player.AddForce(transform.right * -rollImpulse, mode);
            }
            stopRoll = true;
            timerFinishRoll = timerStartRoll;
        }
        if (stopRoll == true)
        {
            if (timerFinishRoll >= 0)
            {
                timerFinishRoll -= 1f * Time.deltaTime;
            }
            else
            {
                player.velocity = new Vector2(0f, 0f);
                stopRoll = false;
            }
        }
    }
}
