using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSkills : MonoBehaviour
{
    [SerializeField] private Text countSkillsText;
    public int countSkills;

    void Start()
    {
    }
    
    void Update()
    {
        countSkillsText.text = countSkills.ToString();        
    }
}
