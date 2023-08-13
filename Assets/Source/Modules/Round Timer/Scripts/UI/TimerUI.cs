using UnityEngine;
using TMPro;

namespace RoundTimer
{
    public class TimerUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textTime;

        internal void ViewTime(float amount)
        {
            int seconds = (int)amount;
            _textTime.text = $"0:{seconds}";
        }
    }
}
