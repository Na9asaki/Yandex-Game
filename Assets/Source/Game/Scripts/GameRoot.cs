using RoundTimer;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    [SerializeField] private PlankFactory _plankFactory;
    [SerializeField] private TimerRoot _timerRoot;
    
    private void Start()
    {
        _plankFactory.Activate();
        _timerRoot.Activate();
    }
}
