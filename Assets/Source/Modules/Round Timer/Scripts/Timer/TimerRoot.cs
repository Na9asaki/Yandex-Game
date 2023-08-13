using UnityEngine;

namespace RoundTimer
{
    public class TimerRoot : MonoBehaviour
    {
        [SerializeField] private FirstRound _firstRound;
        
        public void Activate()
        {   
            _firstRound.Activate();
        }
    }
}
