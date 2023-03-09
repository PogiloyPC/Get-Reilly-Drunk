using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySkills : MonoBehaviour
{
    [SerializeField] private ShopSkills countSkills;
    [SerializeField] private GameObject buttonBuy;
    [SerializeField] private GameObject buttonSelect;
    [SerializeField] private GameObject buttonDelete;
    [SerializeField] private Image image;
    [SerializeField] private MovingPlayer player;
    [SerializeField] private Text textPrice;
    public int idSkills;
    public int price;
   
    void Start()
    {
        textPrice.text = price.ToString();
        image.color = Color.red;
    }        

    public void Buy()
    {
        if (player.countMoney >= price)
        {
            buttonBuy.SetActive(false);            
            buttonSelect.SetActive(true);
            buttonDelete.SetActive(true);
            image.gameObject.SetActive(true);
            player.countMoney -= price;            
        }
    }

    public void SelectSkills()
    {
        if (countSkills.countSkills < 2)
        {
            countSkills.countSkills += 1;
            for (int i = 0; i < player.skills.Length; i++)
            {
                if (i == idSkills)
                {
                    player.skills[i].SetActive(true);
                    image.color = Color.green;
                }            
            }
        }
    }

    public void DeleteSkills()
    {
        if (countSkills.countSkills > 0 && image.color == Color.green)
        {
            countSkills.countSkills -= 1;
            for (int i = 0; i < player.skills.Length; i++)
            {
                if (i == idSkills)
                {
                    image.color = Color.red;
                    player.skills[i].SetActive(false);
                }           
            }
        }
    }
}
