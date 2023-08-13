using UnityEngine;

namespace RoundTimer
{
    internal class PlayerInput : MonoBehaviour
    {
        [SerializeField] private ClickCounterUI _clickCounterUI;

        private int _countOfClick;
        

        private bool _active;

        public void Activate()
        {
            _active = true;
            _countOfClick = 0;
            _clickCounterUI.CountView(_countOfClick);
        }

        public void Deactivate() => _active = false;

        private void Update()
        {
            if (!_active)
                return;
            if (Input.GetMouseButtonDown(0))
            {
                _countOfClick++;
                _clickCounterUI.CountView(_countOfClick);
            }
        }

        internal int GetCountClick()
        {
            return _countOfClick;
        }
    }
}
