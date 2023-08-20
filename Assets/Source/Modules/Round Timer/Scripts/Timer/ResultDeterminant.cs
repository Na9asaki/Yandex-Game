using System;
using UnityEngine;

namespace RoundTimer
{
    public class ResultDeterminant : MonoBehaviour
    {
        [SerializeField] private PlankFactory _plankFactory;
        [SerializeField] private GameObject _plank;
        [SerializeField] private PlayerInput _playerInput;

        public event Action<byte> ResultEvent;
        
        private bool _active;
        private float _gameResult;

        private void OnTriggerEnter(Collider other)
        {
            if (!_active)
                return;
            var result = Mathf.Abs(_playerInput.GetCountClick() - _gameResult) / _gameResult;
            byte finalStars = 0;
            if (result - .1f <= 1e-3)
                finalStars = 3;
            else if (result - .3f <= 1e-3)
                finalStars = 2;
            else
                finalStars = 1;
            ResultEvent?.Invoke(finalStars);
            Deactivate();
        }

        public void Activate()
        {
            _active = true;
            _gameResult = _plankFactory.GetAllEndurence();
            _plank.SetActive(false);
        }

        public void Deactivate() => _active = false;
    }
}
