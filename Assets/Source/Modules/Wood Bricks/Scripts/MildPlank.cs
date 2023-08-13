using UnityEngine;

internal class MildPlank : Plank
{
    [SerializeField, Min(0)] private const float Endurence = 2f;

    protected override float GetEndurence()
    {
        return Endurence;
    }
}
