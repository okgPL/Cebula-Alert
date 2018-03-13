using System;
using System.IO;
using UnityEngine;

public class Saves : MonoBehaviour
{
    private void Start()
    {
        if (File.Exists("save.bin"))
        {
            using (StreamReader sr = new StreamReader("save.bin"))
            {
                GameObject.Find("MoneyBalance").GetComponent<Money>().Add(Convert.ToDouble(sr.ReadLine()));
                GameObject.Find("MoneyBalance").GetComponent<Money>().SetCurrencyCode(sr.ReadLine());

                for(int i = 0; !sr.EndOfStream; i++)
                    GameObject.Find("GameRules").GetComponent<Inventory>().AddItem(i, Convert.ToInt32(sr.ReadLine()));
                sr.Close();
            }
        }
        else
        {
            GameObject.Find("MoneyBalance").GetComponent<Money>().Add(1);
            GameObject.Find("MoneyBalance").GetComponent<Money>().SetCurrencyCode("PLN");
        }
    }

    public void SaveGame()
    {
        using (StreamWriter sw = new StreamWriter("save.bin"))
        {
            sw.WriteLine(GameObject.Find("MoneyBalance").GetComponent<Money>().GetBalance());
            sw.WriteLine(GameObject.Find("MoneyBalance").GetComponent<Money>().GetCurrencyCode());
            int[] inv = GameObject.Find("GameRules").GetComponent<Inventory>().GetInventory();
            foreach(int x in inv)
                sw.WriteLine(x);
            sw.Close();
            Debug.Log("Game saved");
        }
    }
}
