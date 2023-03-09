using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveShopSlot : MonoBehaviour
{
    [SerializeField] private GameObject countSkills;
    [SerializeField] private ActiveShopSistem shopSistem;
    public int idSlot;

    void Start()
    {
        countSkills.SetActive(false);
    }
    
    void Update()
    {
        
    }

    public void ActiveSlot()
    {
        for (int i = 0; i < shopSistem.shopSlot.Length; i++)
        {
            if (i == idSlot)
            {
                shopSistem.shopSlot[i].SetActive(true);
                if (idSlot == 1)
                {
                    countSkills.SetActive(true);
                }
            }
            else
            {
                if (idSlot != 1)
                {
                    countSkills.SetActive(false);
                }
                shopSistem.shopSlot[i].SetActive(false);
            }
        }
    }
}
