using UnityEngine;

namespace RoundTimer
{
    internal class SecondRound : MonoBehaviour
    {
        [SerializeField] private TimerUI _timerUI;
        [SerializeField] private ResultDeterminant _resultDeterminant;
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private GameObject _wall;

        [SerializeField] private float _roundTimer;

        private bool _active;

        public void Activate()
        {
            _active = true;
            _playerInput.Activate();
            _wall.SetActive(true);
            _timerUI.ViewTime(_roundTimer);
        }

        public void Deactivate()
        {
            _active = false;
            _playerInput.Deactivate();
            _wall.SetActive(false);
        }

        private void Update()
        {
            if (!_active)
                return;
            _roundTimer -= Time.deltaTime;
            _timerUI.ViewTime(_roundTimer);
            if (_roundTimer <= 0f)
            {
                _resultDeterminant.Activate();
                Deactivate();
            }
        }
    }
}
