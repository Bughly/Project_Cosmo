using UnityEngine;

public class Resource : MonoBehaviour // Changed from Resources to Resource
{
    public int durability;
    public int sizeMin;
    public int sizeMax;
    public float regenTime;
    public int tier;
    public ResourceType type;

    public Resource(int _durability, int _sizeMin, int _sizeMax, float _regenTime, int _tier, ResourceType _type)
    {
        durability = _durability;
        sizeMin = _sizeMin;
        sizeMax = _sizeMax;
        regenTime = _regenTime;
        tier = _tier;
        type = _type;
    }
}

public enum ResourceType
{
    Ore,
    Wood,
    Farm,
}