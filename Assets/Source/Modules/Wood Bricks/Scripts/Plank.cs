using UnityEngine;

public abstract class Plank : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, GetEndurence()/3f);
    }

    public abstract float GetEndurence();
}
