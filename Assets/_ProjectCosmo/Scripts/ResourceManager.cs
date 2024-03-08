using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public List<Resource> resources; // Changed from List<Resources> to List<Resource>

    private void Start()
    {
        // Initialize resources
        resources = new List<Resource>();

        // Add resources and set their stats
        Resource woodResource1 = gameObject.AddComponent<Resource>();
        woodResource1.durability = 100;
        woodResource1.sizeMin = 1;
        woodResource1.sizeMax = 3;
        woodResource1.regenTime = 5f;
        woodResource1.tier = 1;
        woodResource1.type = ResourceType.Wood;
        resources.Add(woodResource1);

        Resource woodResource2 = gameObject.AddComponent<Resource>();
        woodResource2.durability = 1700;
        woodResource2.sizeMin = 6;
        woodResource2.sizeMax = 10;
        woodResource2.regenTime = 50f;
        woodResource2.tier = 3;
        woodResource2.type = ResourceType.Wood;
        resources.Add(woodResource2);
    }

    public void GatherResource(Resource resource) // Changed from Resources to Resource
    {
        resource.durability--; // Changed from durability to HP
        if (resource.durability <= 0)
        {
            Debug.Log("RESOURCE DEPLETED");
            RegenerateResource(resource);
        }
    }

    public void RegenerateResource(Resource resource) // Changed from Resources to Resource
    {
        StartCoroutine(RegenCoroutine(resource));
    }

    IEnumerator RegenCoroutine(Resource resource) // Changed from Resources to Resource
    {
        yield return new WaitForSeconds(resource.regenTime); // Changed from regenTime to RegenTime
    }
}