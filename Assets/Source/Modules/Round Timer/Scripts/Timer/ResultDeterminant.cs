using System;
using UnityEngine;

namespace RoundTimer
{
    public class ResultDeterminant : MonoBehaviour
    {
        [SerializeField] private float _gameResult;
        [SerializeField] private GameObject _plank;
        [SerializeField] private PlayerInput _playerInput;

        private bool _active;

        private void OnTriggerEnter(Collider other)
        {
            if (!_active)
                return;
            var result = Mathf.Abs(_playerInput.GetCountClick() - _gameResult) / _gameResult;
            if (result - .1f <= 1e-3)
                Debug.Log("Three stars!");
            else if (result - .3f <= 1e-3)
                Debug.Log("Two stars!");
            else
                Debug.Log("One star!");
        }

        public void Activate()
        {
            _active = true;
            _plank.SetActive(false);
        }

        public void Deactivate() => _active = false;
    }
}
