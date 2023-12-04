using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI MoneyTxt;
    public List<LayoutScript> layoutScripts;

    private float money = 0f;
    public float Money
    {
        get => money;
        set
        {
            money = value;
            foreach (var script in layoutScripts)
            {
                script.UpdateAll();
            }
        }
    }

    public void GameOver() { 
    }

    public void RewardMoney(float amount) {
        Money += amount;
        MoneyTxt.text = $"${Money}";
    }
}
