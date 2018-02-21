using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cebula_Alert
{
	/// <summary>
	/// Shows and services money balance
	/// </summary>
	public class Money : MonoBehaviour 
	{
		/// <summary>
		/// Object which shows money balance (top of the screen)
		/// </summary>
		public GameObject balanceViewer;
		/// <summary>
		/// Money balance
		/// </summary>
		private double moneyBalance = 99.99;
		private string currencycode = "PLN";

		/// <summary>
		/// Updates balance viewer
		/// </summary>
		void Update () 
		{
			balanceViewer.GetComponent<TMPro.TextMeshPro>().text = (moneyBalance.ToString ()+ " " + currencycode);
		}
		/// <summary>
		/// Add the specified value
		/// </summary>
		/// <param name="value">Amount of money to aff</param>
		void Add(double value)
		{
			moneyBalance += value;
		}

		/// <summary>
		/// Subtract the specified value
		/// Returns 1 if balance is lower than amount, 0 otherwise
		/// </summary>
		/// <param name="value">Amount of money to subtract</param>
		int Subtract (double value)
		{
			if (moneyBalance <= value) {
				moneyBalance -= value;	
				return 0;
			} else
				return 1;
		}
	}
}