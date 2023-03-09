using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteClonePlayer : MonoBehaviour
{

    void Start()
    {
        
    }
    
    void Update()
    {
        Destroy(gameObject, 0.8f);
    }
}
