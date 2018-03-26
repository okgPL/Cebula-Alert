using UnityEngine;

namespace CA
{
    public class Inventory : MonoBehaviour
    {
        private int[] inventory = new int[2]; //Please remember to increment that while adding a new item to the game

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