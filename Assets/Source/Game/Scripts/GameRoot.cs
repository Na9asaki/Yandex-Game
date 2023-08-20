using System;
using System.Collections.Generic;
using PlankShredder;
using PlankShredder.Source.Game.Scripts;
using RoundTimer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRoot : MonoBehaviour
{
    [SerializeField] private PlankFactory _plankFactory;
    [SerializeField] private EndGamePanelUI _endGamePanelUI;
    [SerializeField] private TimerRoot _timerRoot;
    [SerializeField] private List<LevelType> _levelTypes;

    private byte _id = CurrentLevelInfo.CurrentLevel;

    private byte ID
    {
        get => _id;
        set
        {
            if (_id + 1 >= _levelTypes.Count)
                throw new IndexOutOfRangeException("Level ID overflow");
            CurrentLevelInfo.CurrentLevel++;
        }
    }
    
    private void Start()
    {
        Activate();
    }

    private void OnEnable()
    {
        _endGamePanelUI.LevelUpdateEvent += LoadLevel;
    }

    private void OnDisable()
    {
        _endGamePanelUI.LevelUpdateEvent -= LoadLevel;
    }

    private void Activate()
    {
        _plankFactory.Activate(_levelTypes[ID]);
        _timerRoot.Activate();
    }

    private void LoadLevel(LevelLoadingType actionType)
    {
        switch (actionType)
        {
            case LevelLoadingType.MenuScene:
                SceneManager.LoadScene(0);
                break;
            case LevelLoadingType.RestartLevel:
                SceneManager.LoadScene(1);
                break;
            case LevelLoadingType.StartNextLevel:
                ID++;
                SceneManager.LoadScene(1);
                break;
        }
    }
}
