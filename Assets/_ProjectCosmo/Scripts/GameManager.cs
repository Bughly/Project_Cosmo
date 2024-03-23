using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private int oxygenTick;
    private int maxOxygenTick;
    public static string currentPlanet = "Moon";
    public static bool isIndoors = false;
    private static Vector3 originalGravity;
    
    // GameTick.OnTick += GameTick_OnTick;
    
    // Start is called before the first frame update
    void Start()
    {

        originalGravity = Physics.gravity;
        
        GameTick.OnTick += delegate(object sender, GameTick.OnTickEventArgs e)
        {
            //Debug.Log("Tick:" + e.tick);
        }; // Why does this need a fucking ;?????

        GetCurrentGravity();

    }

    // ** TODO: MAKE THIS NOT A FUCKING IF STATEMENT THAT IS HARD CODED IN THE FUNCTION
    public static void GetCurrentGravity()
    {
        if (isIndoors)
        {
            Physics.gravity = originalGravity;
        }
        else
        {
            if (currentPlanet == "Moon")
            {
                Physics.gravity = new Vector3(0, -2, 0);
            }
        }
        
    }
}
