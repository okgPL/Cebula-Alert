using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
	private List <Product> inv = new List<Product>();

	public void Add(Product product)
	{
		Product ap = inv.Find (Product => Product.productName == product.productName);
		if (ap == product)
			inv.Find (Product => Product.productName == product.productName).amount++;
		else
			inv.Add (ap);
		Debug.Log("Added product " + product.productName + " to inventory");
	}

	public int Remove(Product product)
	{
		Product ap = inv.Find (Product => Product.productName == product.productName);
		if (ap.amount > 1) {
			inv.Find (Product => Product.productName == product.productName).amount--;
			Debug.Log ("Removed product " + product.productName + " from inventory");
			return 0;
		} else if (ap.amount == 1) {
			inv.Remove (ap);
			Debug.Log ("Removed product " + product.productName + " from inventory");
			return 0;
		} else {
			Debug.Log ("Removing product " + product.productName + " doesn't exist in inventory");
			return 1;
		}
	}
}