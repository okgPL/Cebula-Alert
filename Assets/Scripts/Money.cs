using System;
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
	private double moneyBalance = 0;
	private string currencycode = "PLN";
	public bool BuyMode = true;
	/// <summary>
	/// Updates balance viewer
	/// </summary>
	void Update () 
	{
        balanceViewer.GetComponent<TMPro.TextMeshPro>().text = string.Format("{0:F2}", Math.Round(moneyBalance, 2).ToString()) + " " + currencycode;
	}
	/// <summary>
	/// Add the specified value
	/// </summary>
	/// <param name="value">Amount of money to aff</param>
	public void Add(double value)
	{
		moneyBalance += value;
		Debug.Log ("Added " + value + " to money balance");
	}

	/// <summary>
	/// Subtract the specified value
	/// Returns 1 if balance is lower than amount, 0 otherwise
	/// </summary>
	/// <param name="value">Amount of money to subtract</param>
	public int Subtract (double value)
	{
        if (moneyBalance >= value)
        {
            moneyBalance -= value;
            Debug.Log("Subtracted " + value + " from balance");
            return 0;
        }
        else return 1;
	}

    /// <summary>
    /// Sets the Currency Code
    /// </summary>
    /// <param name="code">currency code</param>
    public void SetCurrencyCode(string code)
    {
        currencycode = code;
    }

    /// <summary>
    /// Gets the money balance
    /// </summary>
    /// <returns>Money balance</returns>
    public double GetBalance()
    {
        return moneyBalance;
    }
    
    /// <summary>
    /// Gets the currency code
    /// </summary>
    /// <returns></returns>
    public string GetCurrencyCode()
    {
        return currencycode;
    }
}