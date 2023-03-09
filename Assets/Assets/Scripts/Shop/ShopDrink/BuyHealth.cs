using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHealth : MonoBehaviour
{
    [SerializeField] private MovingPlayer player;
    [SerializeField] private HealthPlayer healthPlayer;
    [SerializeField] private Text scoreL;
    [SerializeField] private Text priceTxt;
    public int price;
    public int L;

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
            healthPlayer.TakeDamage(-L);
        }
    }
}
