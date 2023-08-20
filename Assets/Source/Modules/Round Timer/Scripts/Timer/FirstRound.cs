using UnityEngine;

namespace RoundTimer
{
    internal class FirstRound : MonoBehaviour
    {
        [SerializeField] private TimerUI _timerUI;
        [SerializeField] private SecondRound _secondRound;

        [SerializeField] private float _roundTimer;

        private bool _active;

        public void Activate()
        {
            _active = true;
            _timerUI.ViewTime(_roundTimer);
        }

        public void Deactivate()
        {
            _active = false;
        }

        private void Update()
        {
            if (!_active)
                return;
            _roundTimer -= Time.deltaTime;
            _timerUI.ViewTime(_roundTimer);
            if (_roundTimer <= 0f)
            {
                Deactivate();
                _secondRound.Activate();
            }
        }
    }
}
