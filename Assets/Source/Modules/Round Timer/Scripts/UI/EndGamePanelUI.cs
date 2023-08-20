using System;
using PlankShredder;
using TMPro;
using UnityEngine;

namespace RoundTimer
{
    public class EndGamePanelUI : MonoBehaviour
    {
        [SerializeField] private ResultDeterminant _resultDeterminant;
        [SerializeField] private TMP_Text _textResult;
        [SerializeField] private GameObject _endGamePanel;

        public event Action<LevelLoadingType> LevelUpdateEvent; 
        
        private void OnEnable()
        {
            _resultDeterminant.ResultEvent += UpdatePanel;
        }

        private void OnDisable()
        {
            _resultDeterminant.ResultEvent -= UpdatePanel;
        }

        private void UpdatePanel(byte countStars)
        {
            _endGamePanel.SetActive(true);
            _textResult.text = $"Stars : {countStars}/3";
        }

        public void RestartLevel()
        {
            LevelUpdateEvent?.Invoke(LevelLoadingType.RestartLevel);
            gameObject.SetActive(false);
        }

        public void LoadMenu()
        {
            LevelUpdateEvent?.Invoke(LevelLoadingType.MenuScene);
            gameObject.SetActive(false);
        }

        public void StartNextLevel()
        {
            LevelUpdateEvent?.Invoke(LevelLoadingType.StartNextLevel);
            gameObject.SetActive(false);
        }
    }
}