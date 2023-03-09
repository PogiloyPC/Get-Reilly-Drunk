using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform movePointCamera;    
    public float distance;
    
    void Start()
    {
        
    }
    
    void Update()
    {       
        if (player.position.x > movePointCamera.position.x - distance && player.position.x < movePointCamera.position.x + distance)
        {
            transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        }
    }
}
