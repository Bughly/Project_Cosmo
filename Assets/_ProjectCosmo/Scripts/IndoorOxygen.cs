using UnityEngine;

public class IndoorOxygen : MonoBehaviour
{
    [SerializeField] private float oxygenAmount = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats.oxygenRegenRate = oxygenAmount;
            PlayerStats.isBreathing = true;
            GameManager.isIndoors = true;
            GameManager.GetCurrentGravity();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats.isBreathing = false;
            GameManager.isIndoors = false;
            GameManager.GetCurrentGravity();
        }
    }
}
