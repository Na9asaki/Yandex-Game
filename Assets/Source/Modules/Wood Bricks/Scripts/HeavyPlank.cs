using UnityEngine;

internal class HeavyPlank : Plank
{
    [SerializeField, Min(0)] private const float Endurence = 6f;
    protected override float GetEndurence()
    {
        return Endurence;
    }
}
