using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBloodParticle : MonoBehaviour
{
    public float destroyParticle;

    void Update()
    {
        Destroy(gameObject, destroyParticle);        
    }
}
