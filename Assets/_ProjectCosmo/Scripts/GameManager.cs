using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int oxygenTick;
    private int maxOxygenTick;
    
    // GameTick.OnTick += GameTick_OnTick;
    
    // Start is called before the first frame update
    void Start()
    {
        // Create a new GameObject
        // GameObject resourceManagerObject = new GameObject("ResourceManagerObject");

        // Initialize the ResourceManager (if needed)
        //resourceManager.Initialize(); // You can implement an initialization method in ResourceManager if necessary

        GameTick.OnTick += delegate(object sender, GameTick.OnTickEventArgs e)
        {
            Debug.Log("Tick:" + e.tick);
        }; // Why does this need a fucking ;?????

    }

    // private void GameTick_OnTick(object sender, GameTick.OnTickEventArgs e)
    // {
    //     if (PlayerStats.isBreathing)
    //     {
    //         
    //     }
    // }
    

}
