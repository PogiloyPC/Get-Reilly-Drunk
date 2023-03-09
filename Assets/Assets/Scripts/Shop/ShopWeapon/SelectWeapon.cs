using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeapon : MonoBehaviour
{
    [SerializeField] private MovingPlayer weapon;
    public int idWeapon;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Select()
    {
        for (int i = 0; i < weapon.weapon.Length; i++)
        {
            if (i == idWeapon)
            {
                weapon.weapon[i].SetActive(true);
                weapon.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            else
            {
                weapon.weapon[i].SetActive(false);
            }
        }
    }
}
