using System;
using System.IO;
using UnityEngine;

namespace CA
{
    public class Saves : MonoBehaviour
    {
        private string filename;
        private void Start()
        {
            filename = Application.persistentDataPath + "/save.bin";

            //loads save from file
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    GameObject.Find("MoneyBalance").GetComponent<Money>().Add(Convert.ToDouble(sr.ReadLine()));
                    GameObject.Find("MoneyBalance").GetComponent<Money>().SetCurrencyCode(sr.ReadLine());

                    for (int i = 0; !sr.EndOfStream; i++)
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

        /// <summary>
        /// Saves progress
        /// </summary>
        public void SaveGame()
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(GameObject.Find("MoneyBalance").GetComponent<Money>().GetBalance());
                sw.WriteLine(GameObject.Find("MoneyBalance").GetComponent<Money>().GetCurrencyCode());
                int[] inv = GameObject.Find("GameRules").GetComponent<Inventory>().GetInventory();
                foreach (int x in inv)
                    sw.WriteLine(x);
                sw.Close();
                Debug.Log("Game saved");
            }
        }
    }
}