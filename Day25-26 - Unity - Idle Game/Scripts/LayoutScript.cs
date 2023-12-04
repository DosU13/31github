using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class LayoutScript : MonoBehaviour
{
    public float priceIncremental = 1f;
    public float price;
    public float amountIncremental = 1f;
    public abstract float Amount { get; set; }

    private TextMeshProUGUI amountTxt;
    private TextMeshProUGUI priceTxt;
    private Image btnImage;
    private GameManager gameManager;


    protected void Start()
    {
        var button = transform.Find("Button");
        amountTxt = button.Find("Amount").GetComponent<TextMeshProUGUI>();
        priceTxt = button.Find("Price").GetComponent<TextMeshProUGUI>();
        btnImage = button.GetComponent<Image>();
        gameManager = FindObjectOfType<GameManager>();

        UpdateAll();
    }

    // Update is called once per frame
    public void UpdateAll()
    {
        if (gameManager.Money < price) btnImage.color = Color.grey;
        else btnImage.color = Color.green;
        amountTxt.text = Amount.ToString();
        priceTxt.text = $"${price}";
    }

    public void OnButtonClick()
    {
        if (gameManager.Money < price) return;
        gameManager.Money -= price;
        price += priceIncremental;
        Amount += amountIncremental;
        UpdateAll();
    }
}
