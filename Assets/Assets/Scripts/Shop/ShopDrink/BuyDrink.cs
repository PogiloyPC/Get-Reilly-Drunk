using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyDrink : MonoBehaviour
{
    [SerializeField] private MovingPlayer player;
    [SerializeField] private DrunkennessScale railly;
    [SerializeField] private Text scoreL;
    [SerializeField] private Text priceTxt;
    public int price;
    public int L;
    public string nameDrink;

    void Start()
    {
        priceTxt.text = price.ToString();
        scoreL.text = L.ToString();
    }

    
    void Update()
    {
        
    }

    public void Buy()
    {
        if (player.countMoney >= price)
        {
            player.countMoney -= price;
            railly.Binge(L);
        }
    }
}
