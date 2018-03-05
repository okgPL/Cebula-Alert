using UnityEngine;
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
	public bool BuyMode = true;
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
	public void Add(double value)
	{
		moneyBalance += value;
		Debug.Log ("Added " + value + "to balance");
	}

	/// <summary>
	/// Subtract the specified value
	/// Returns 1 if balance is lower than amount, 0 otherwise
	/// </summary>
	/// <param name="value">Amount of money to subtract</param>
	public int Subtract (double value)
	{
		if (moneyBalance <= value) {
			moneyBalance -= value;	
			Debug.Log ("Subtracted " + value + "from balance");
			return 0;
		} else
			return 1;
	}
}