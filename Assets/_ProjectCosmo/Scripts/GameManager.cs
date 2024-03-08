using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create a new GameObject
        GameObject resourceManagerObject = new GameObject("ResourceManagerObject");

        // Add the ResourceManager component to the new GameObject
        ResourceManager resourceManager = resourceManagerObject.AddComponent<ResourceManager>();

        // Initialize the ResourceManager (if needed)
        //resourceManager.Initialize(); // You can implement an initialization method in ResourceManager if necessary
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
