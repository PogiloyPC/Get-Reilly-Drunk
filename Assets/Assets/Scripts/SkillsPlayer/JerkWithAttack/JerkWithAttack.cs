using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerkWithAttack : MonoBehaviour
{    
    [Header("Player")]
    [SerializeField] private GameObject player;
    [SerializeField] private PlayerCloneMove clonePlayer;
    [SerializeField] private Transform clonePos;
    [SerializeField] private GameObject shop;
    Vector3 difference;
    public float speedJerkWithAttack;
    public float startTimerInvis;
    private float finishTimerInvis;
    

    void Start()
    {        
    }
    
    void Update()
    {
        if (finishTimerInvis <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1) && shop.activeSelf == false)
            {
                
                difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                clonePlayer.difference = difference;
                Instantiate(clonePlayer.gameObject, clonePos.position, Quaternion.identity);
                if (difference.x < player.transform.position.x)
                {
                    clonePlayer.transform.localScale = new Vector3(-1f, 1f, 1f);
                }
                else
                {
                    clonePlayer.transform.localScale = new Vector3(1f, 1f, 1f);
                }
                finishTimerInvis = startTimerInvis;                
            }       
        }
        else
        {
            finishTimerInvis -= 1f * Time.deltaTime;
        }          
    }   
}
