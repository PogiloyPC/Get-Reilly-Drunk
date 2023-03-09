using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private GameObject cam;

    void Start()
    {
        
    }
   
    void Update()
    {
        transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, 60f);
    }
}
