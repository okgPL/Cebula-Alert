
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int[] inventory = new int[2]; //2 because I wanted an array, please remember to increment that while adding a new item to the game

    public void AddItem(int index, int amount)
    {
        inventory[index] += amount;
    }

    public bool RemoveItem(int index, int amount)
    {
        if (inventory[index]-amount < 0) return false;
        else
        {
            inventory[index] -= amount;
            return true;
        }
    }
}
