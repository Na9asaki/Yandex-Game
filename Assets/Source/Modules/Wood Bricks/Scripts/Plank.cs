using UnityEngine;

internal abstract class Plank : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, GetEndurence()/3f);
    }

    protected abstract float GetEndurence();
}
