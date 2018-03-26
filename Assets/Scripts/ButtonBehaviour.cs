using UnityEngine;

namespace CA
{
    public class ButtonBehaviour : MonoBehaviour
    {
        //public Button button;
        public GameObject paskiBuy, paskiSell;

        public void BuyClick()
        {
            paskiBuy.SetActive(true);
            paskiSell.SetActive(false);

            Debug.Log("Gamemode set: Buy");
            GameObject.Find("MoneyBalance").GetComponent<Money>().BuyMode = true;
        }

        public void SellClick()
        {
            paskiBuy.SetActive(false);
            paskiSell.SetActive(true);

            Debug.Log("Gamemode set: Sell");
            GameObject.Find("MoneyBalance").GetComponent<Money>().BuyMode = false;
        }
    }
}