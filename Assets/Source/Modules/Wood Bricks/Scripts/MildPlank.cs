using UnityEngine;

internal class MildPlank : Plank
{
    [SerializeField, Min(0)] private const float Endurence = 2f;

    public override float GetEndurence()
    {
        return Endurence;
    }
}
