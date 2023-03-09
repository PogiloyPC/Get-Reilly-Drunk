using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol : MonoBehaviour
{
    private GameObject drink;
    public float alcoholLL;

    void Start()
    {
        drink = GameObject.Find("Railly");
    }
    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        DrunkennessScale drunk = drink.GetComponent<DrunkennessScale>();
        if (collision.gameObject.tag == "Player")
        {
            drunk.Binge(alcoholLL);
            Destroy(gameObject);
        }
    }
}
