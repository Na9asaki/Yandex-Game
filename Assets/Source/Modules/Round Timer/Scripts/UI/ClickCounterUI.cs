using TMPro;
using UnityEngine;

namespace RoundTimer
{
    internal class ClickCounterUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textClickCount;

        internal void CountView(int amount)
        {
            _textClickCount.text = amount.ToString();
        }
    }
}
