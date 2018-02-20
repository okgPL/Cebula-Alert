using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cebula_Alert
{
	/// <summary>
	/// Describes the product
	/// </summary>
	public class Product : MonoBehaviour
	{
		public double price;
		public string productName;
		public string amount; //used in inventory
		public GameObject PriceHolder;
		/// <summary>
		/// Start this instance.
		/// </summary>
		void Start()
		{
			PriceHolder.GetComponent<TMPro.TextMeshPro> ().text = price.ToString ();
		}
	}
}