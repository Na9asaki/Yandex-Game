using UnityEngine;

public class PlankFactory : MonoBehaviour
{
    [SerializeField] private Plank[] _planks;
    [SerializeField] private Transform[] _position;
    
    internal void Create()
    {
        for (int i = 0; i < _position.Length; i++)
        {
            Instantiate(_planks[i], _position[i].position, _position[i].rotation);
        }
    }

    public void Activate()
    {
        Create();
    }
}
