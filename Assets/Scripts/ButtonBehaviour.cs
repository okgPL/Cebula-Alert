using UnityEngine;

namespace CA
{
    public class ButtonBehaviour : MonoBehaviour
    {
        //public Button button;
        public GameObject paskiBuy, paskiSell, canvasMain, canvasInv, camMain, camInv;

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

        public void InvButton()
        {
            camMain.SetActive(false);
            camInv.SetActive(true);
            canvasMain.SetActive(false);
            canvasInv.SetActive(true);
        }

        public void InvBack()
        {
            camMain.SetActive(true);
            camInv.SetActive(false);
            canvasMain.SetActive(true);
            canvasInv.SetActive(false);
        }
    }
}