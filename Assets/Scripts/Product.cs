using UnityEngine;
using System;

/// <summary>
/// Describes the product
/// </summary>
public class Product : MonoBehaviour
{
    public double buyPrice, sellPrice;
    public string productName;
    public GameObject PriceHolder; //object which shows a price
    public bool isBuying; //player will buy item if it's true and sell if it's false
    private DateTime time;
    public int saleDuration;
    public int saleTrigger;

    /// <summary>
    /// Update this instance.
    /// </summary>
    void Update()
    {
        time = DateTime.Now;
        int minute = time.Minute;
        int second = time.Second;
        double sell;
        if (minute % saleTrigger == 0 && saleDuration > second)
            sell = sellPrice + sellPrice * 0.2;
        else sell = sellPrice;


        isBuying = GameObject.Find("MoneyBalance").GetComponent<Money>().BuyMode;
        if (isBuying)
            PriceHolder.GetComponent<TMPro.TextMeshPro>().text = string.Format("{0:F2}", buyPrice);
        else
            PriceHolder.GetComponent<TMPro.TextMeshPro>().text = string.Format("{0:F2}", sell);
    }

    public void ButtonClick()
    {
        if (isBuying)
        {
            if (GameObject.Find("MoneyBalance").GetComponent<Money>().Subtract(buyPrice) != 1)
                Debug.Log("Item " + productName + " bought");
        }
        else
        {
            GameObject.Find("MoneyBalance").GetComponent<Money>().Add(sellPrice);
            Debug.Log("Item " + productName + " sold");
        }
    }
}