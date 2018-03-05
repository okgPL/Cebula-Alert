using UnityEngine;

/// <summary>
/// Describes the product
/// </summary>
public class Product : MonoBehaviour
{
	public double buyPrice, sellPrice;
	public string productName;
	public uint amount; //for future, will be used by inventory
	public GameObject PriceHolder; //object which shows a price
	public bool isBuying; //player will buy item if it's true and sell if it's false

	Product (string name = "AAA", uint amt = 1)
	{
		productName = name;
		amount = amt;
	}



	/// <summary>
	/// Update this instance.
	/// </summary>
	void Update ()
	{
		isBuying = GameObject.Find ("MoneyBalance").GetComponent <Money> ().BuyMode;
		if (isBuying)
			PriceHolder.GetComponent<TMPro.TextMeshPro> ().text = buyPrice.ToString ();
		else
			PriceHolder.GetComponent<TMPro.TextMeshPro> ().text = sellPrice.ToString ();
	}

	public void onMouseDown ()
	{
		if (isBuying) {
			if (GameObject.Find ("MoneyBalance").GetComponent <Money> ().Subtract (buyPrice) != 1) {
				//GameObject.Find ("Inventory").GetComponent <Inventory> ().Add (gameObject.AddComponent( Product (productName, 1) != 1));
				Debug.Log("Item " + productName + " bought");
			}
		} else {
			//if (GameObject.Find ("Inventory").GetComponent <Inventory> ().Remove (gameObject.AddComponent( Product (productName, 1) != 1))) {
				GameObject.Find ("MoneyBalance").GetComponent <Money> ().Add (sellPrice);
				Debug.Log("Item " + productName +" sold");
			//}
		}
	}
}