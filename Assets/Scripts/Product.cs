using UnityEngine;
using System;

namespace CA
{
    /// <summary>
    /// Describes the product
    /// </summary>
    public class Product : MonoBehaviour
    {
        public int productID; //for inventory proposes
        public double buyPrice, sellPrice;
        public int saleDuration, saleTrigger;
        public string productName;

        public GameObject PriceHolder, PriceBG;
        public bool isBuying; //player will buy item if it's true and sell if it's false
        private DateTime time;
        private double sell;

        /// <summary>
        /// Update this instance.
        /// </summary>
        void Update()
        {
            //Sale trigger
            time = DateTime.Now;
            int minute = time.Minute;
            int second = time.Second;
            sell = sellPrice;
            if (minute % saleTrigger == 0 && saleDuration > second)
                sell += sellPrice * 0.2;

            //setting up the price 
            isBuying = GameObject.Find("MoneyBalance").GetComponent<Money>().BuyMode;
            if (isBuying)
                PriceHolder.GetComponent<TMPro.TextMeshPro>().text = string.Format("{0:F2}", buyPrice);
            else
                PriceHolder.GetComponent<TMPro.TextMeshPro>().text = string.Format("{0:F2}", sell);

            //sets the price background if sale is active       
            if (!isBuying && sell != sellPrice)
                PriceBG.SetActive(true);
            else
                PriceBG.SetActive(false);
        }

        /// <summary>
        /// Pressing button action
        /// </summary>
        public void ButtonClick()
        {
            if (isBuying)
            {
                if (GameObject.Find("MoneyBalance").GetComponent<Money>().Subtract(buyPrice) != 1)
                {
                    GameObject.Find("GameRules").GetComponent<Inventory>().AddItem(productID, 1);
                    Debug.Log("Item " + productName + " bought");
                }
            }
            else
            {
                if (GameObject.Find("GameRules").GetComponent<Inventory>().RemoveItem(productID, 1))
                {
                    GameObject.Find("MoneyBalance").GetComponent<Money>().Add(sell);
                    Debug.Log("Item " + productName + " sold");
                }
            }
            GameObject.Find("GameRules").GetComponent<Saves>().SaveGame();
        }
    }
}