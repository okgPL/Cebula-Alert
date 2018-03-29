using UnityEngine;
using System;

namespace CA
{
    public class Inventory : MonoBehaviour
    {
        private int[] inventory = new int[2]; //Please remember to increment that while adding a new item to the game
        public GameObject[] products;
        public GameObject list, qty;

        /// <summary>
        /// Sets up the list in inventory
        /// </summary>
        private void Start()
        {
            string newlist = "";
            foreach(GameObject x in products)
              newlist +=  x.GetComponent<Product>().productName + "\n";
            list.GetComponent<TMPro.TextMeshPro>().text = newlist;
        }

        /// <summary>
        /// Updates the inventory list
        /// </summary>
        private void Update()
        {
            string newlist = "";
            foreach (int x in inventory)
                newlist += Convert.ToInt32(x) + "\n";
            qty.GetComponent<TMPro.TextMeshPro>().text = newlist;
        }

        /// <summary>
        /// Adds item to inventory
        /// </summary>
        /// <param name="index">item index</param>
        /// <param name="amount">amount of product to add</param>
        public void AddItem(int index, int amount)
        {
            inventory[index] += amount;
        }

        /// <summary>
        /// Removes item from inventory
        /// </summary>
        /// <param name="index">item index</param>
        /// <param name="amount">amount of product to remove</param>
        /// <returns>FALSE if there's no products to remove, TRUE otherwise</returns>
        public bool RemoveItem(int index, int amount)
        {
            if (inventory[index] - amount < 0) return false;
            else
            {
                inventory[index] -= amount;
                return true;
            }
        }

        /// <summary>
        /// Gets the inventory
        /// </summary>
        /// <returns>Inventory array</returns>
        public int[] GetInventory()
        {
            return inventory;
        }
    }
}