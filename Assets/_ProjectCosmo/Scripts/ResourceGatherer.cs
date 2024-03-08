using System.Collections;
using UnityEngine;

public class ResourceGatherer : MonoBehaviour
{
    public float gatherRange = 2f;
    public LayerMask resourceLayer;

    public void Awake()
    {
        resourceLayer = LayerMask.GetMask("Resource");
    }

    private void Update()
    {
        // Check for player input to gather resources
        if (Input.GetButtonDown("Fire1") && InRange())
        {
            GatherResources();
        }

        // Vector3 forward = transform.TransformDirection(Vector3.forward);
        // Debug.DrawRay(transform.position, forward, Color.green);
    }

    private bool InRange()
    {
        // Cast a ray forward from the player to detect resources within gatherRange
        RaycastHit hitCheck;
        if (Physics.Raycast(transform.position, transform.forward, out hitCheck, gatherRange, resourceLayer))
        {
            Debug.Log("Checking");
            return hitCheck.collider != null;
        }

        Debug.Log("Failed?");
        return false;
    }

    private void GatherResources()
    {
        Debug.Log("Gathering.....");

        // Cast a ray forward from the player to detect resources within gatherRange
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, gatherRange, resourceLayer))
        {
            Debug.Log("Raycast hit: " + hit.collider.gameObject.name); // Debug the name of the object hit
            Debug.DrawLine(transform.position, hit.point, Color.red, 1f); // Draw a red line from player to hit point
        
            Resource resource = hit.collider.GetComponent<Resource>();
            if (resource != null)
            {
                Debug.Log("Resource component found.");
                // Gather resource
                resource.Gather();
            }
            else
            {
                Debug.Log("Resource component not found.");
            }
        }
        else
        {
            Debug.Log("Raycast did not hit any resource.");
        }
    }



}
