using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyWeapon : MonoBehaviour
{
    [SerializeField] private GameObject buttonBuy;
    [SerializeField] private GameObject buttonSelect;
    [SerializeField] private MovingPlayer countMoney;
    public int idWeapon;
    public int price;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void BuyWeaponPerMoney()
    {
        if (countMoney.countMoney >= price)
        {
            buttonBuy.SetActive(false);
            buttonSelect.SetActive(true);
            countMoney.countMoney -= price;
            for (int i = 0; i < countMoney.weapon.Length; i++)
            {
                if (i == idWeapon)
                {
                    countMoney.weapon[i].SetActive(true);
                }
                else
                {
                    countMoney.weapon[i].SetActive(false);
                }
            }
        }
    }
}
