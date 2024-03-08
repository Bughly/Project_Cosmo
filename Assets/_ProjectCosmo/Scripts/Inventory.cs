using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, int> items = new Dictionary<string, int>(); // Dictionary to store items and their quantities
    
    // Method to add an item to the inventory
    public void AddItem(string itemName, int amount)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += amount;
        }
        else
        {
            items.Add(itemName, amount);
        }
    }
    
    // Method to remove an item from the inventory
    public void RemoveItem(string itemName, int amount)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] -= amount;
            if (items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
        }
    }
    
    // Method to check if the inventory contains a certain item
    public bool HasItem(string itemName)
    {
        return items.ContainsKey(itemName);
    }
    
    // Method to get the quantity of a certain item in the inventory
    public int GetItemQuantity(string itemName)
    {
        return items.ContainsKey(itemName) ? items[itemName] : 0;
    }

    public Dictionary<string, int> GetAllItems()
    {
        return new Dictionary<string, int>(items);
    }
}

