using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float newGravity = -5f;

    private Rigidbody playerRigidbody;
    private Vector3 originalGravity;

    private void Start()
    {
        playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        originalGravity = Physics.gravity;
    }

    private void Update()
    {
        Debug.Log(Physics.gravity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Physics.gravity = new Vector3(0, newGravity, 0);
            PlayerStats.isBreathing = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Physics.gravity = originalGravity;
            PlayerStats.isBreathing = true;
        }
    }
}
