using PlankShredder;
using UnityEngine;

public class PlankFactory : MonoBehaviour
{
    [SerializeField] private Transform[] _position;
    [SerializeField] private Transform _parent;

    private LevelType _levelType;
    
    internal void Create()
    {
        var planks = _levelType.Planks;
        for (int i = 0; i < planks.Count; i++)
        {
            Instantiate(planks[i], _position[i].position, Quaternion.identity);
        }
    }

    public void Activate(LevelType levelType)
    {
        _levelType = levelType;
        Create();
    }

    public float GetAllEndurence()
    {
        return _levelType.AllEndurence;
    }
}
