using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class InventoryDisplay : MonoBehaviour
{
    public TextMeshProUGUI inventoryText; // Reference to the UI Text component
    public Inventory playerInventory; // Reference to the Inventory script attached to the player GameObject

    // Update is called once per frame
    void Update()
    {
        // Check if the inventoryText reference and playerInventory reference are set
        if (inventoryText != null && playerInventory != null)
        {
            // Get the inventory contents and update the UI Text
            string inventoryContents = GetInventoryContents();
            inventoryText.text = "Inventory:\n" + inventoryContents;
        }
    }

    // Method to get the inventory contents
    string GetInventoryContents()
    {
        // Create an empty string to store the inventory contents
        string contents = "";

        // Get all items in the player's inventory
        Dictionary<string, int> inventoryItems = playerInventory.GetAllItems();

        // Loop through each item in the player's inventory
        foreach (KeyValuePair<string, int> item in inventoryItems)
        {
            // Append the item name and quantity to the contents string
            contents += item.Key + ": " + item.Value + "\n";
        }

        return contents;
    }
}