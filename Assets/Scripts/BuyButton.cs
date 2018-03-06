using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour {

    //public Button button;
    public GameObject paskiBuy, paskiSell;

    public void Click()
    {
        paskiBuy.SetActive(true);
        paskiSell.SetActive(false);

        Debug.Log("Gamemode set: Buy");
        GameObject.Find("MoneyBalance").GetComponent < Money>().BuyMode = true;
    }
}
