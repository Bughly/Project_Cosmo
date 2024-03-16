using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [Header("Oxygen")]
    public float playerOxygen = 100f;
    public float maxPlayerOxygen = 100f;
    public float minPlayerOxygen = 0;
    public float oxygenRegenRate = 3f;
    public static float oxygenDegenRate = 0.5f;
    public static bool isBreathing = true;
    [Header("Stamina")]
    public float playerStamina = 100f;
    public float maxPlayerStamina = 100f;
    [Header("Health")]
    public float playerHealth = 100f;
    public float maxPlayerHealth = 100f;
    [Header("Weight")]
    public float playerWeight = 100f;
    public float maxPlayerWeight = 100f;
    [Header("Mass")]
    public float playerMass = 100f;
    
    // ###############################
    public TextMeshProUGUI statsText;

    private void Start()
    {
        playerOxygen = maxPlayerOxygen;
        playerStamina = maxPlayerStamina;
        playerHealth = maxPlayerHealth;
        playerWeight = maxPlayerWeight;
    }

    private void Update()
    {
        statsText.text = $"Oxygen: {playerOxygen} / {isBreathing}\nStamina: {playerStamina}\nHealth: {playerHealth}\nWeight: {playerWeight}\nMass: {playerMass}";
    }
    
    // ################## Breathing ##################
    private void OnEnable()
    {
        GameTick.OnTick += HandleTick;
    }

    private void OnDisable()
    {
        GameTick.OnTick -= HandleTick;
    }

    private void HandleTick(object sender, GameTick.OnTickEventArgs e)
    {
        if (isBreathing)
        {
            RegenerateOxygen();
        }

        if (!isBreathing)
        {
            DegenerateOxygen();
        }
    }

    private void RegenerateOxygen()
    {
        playerOxygen += oxygenRegenRate;
        // Clamp the oxygen level to ensure it doesn't exceed the max
        playerOxygen = Mathf.Clamp(playerOxygen, minPlayerOxygen, maxPlayerOxygen);
    }

    private void DegenerateOxygen()
    {
        playerOxygen -= oxygenDegenRate;
        // Clamp the oxygen level to ensure it doesn't exceed the max
        playerOxygen = Mathf.Clamp(playerOxygen, minPlayerOxygen, maxPlayerOxygen);
        if (playerOxygen <= minPlayerOxygen)
        {
            Suffocate();
        }
            
    }
    
    // ################## Health ##################
    private void Suffocate()
    {
        playerHealth--;
        if (playerHealth <= 0)
        {
            Debug.Log("Ded");
        }
    }
}       
