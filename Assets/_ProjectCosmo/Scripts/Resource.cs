using UnityEngine;

public class Resource : MonoBehaviour
{
    public string resourceName = "Resource";
    public int resourceAmount = 10;
    public float gatherTime = 1f;
    public int resourceHealth = 100;

    private Inventory inventory;
    [SerializeField] private GameObject player;

    private void Start()
    {
        inventory = player.GetComponent<Inventory>(); // Find the Inventory component in the scene
    }

    public void Gather()
    {
        if (resourceHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        
        Debug.Log("Function Gather");
        // Play gathering animation, sound effects, etc.
        // Deduct stamina/durability from player tool
        
        // Simulate gathering time with Invoke
        Invoke("CompleteGathering", gatherTime);
    }

    public void CompleteGathering()
    {
        // Perform actions when gathering is complete
        // For example, add the gathered resource to the player's inventory
        inventory.AddItem(resourceName, resourceAmount);
        // You can also destroy or disable the resource object
        Debug.Log("Resource gathered!" + inventory.GetItemQuantity(resourceName));
    }
}
