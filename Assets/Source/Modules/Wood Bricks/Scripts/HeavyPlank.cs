using UnityEngine;

internal class HeavyPlank : Plank
{
    [SerializeField, Min(0)] private const float Endurence = 6f;
    public override float GetEndurence()
    {
        return Endurence;
    }
}
