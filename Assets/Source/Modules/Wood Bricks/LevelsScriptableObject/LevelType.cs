using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlankShredder
{
    [CreateAssetMenu(menuName = "Levels Scriptable", fileName = "Planks List", order = 51)]
    public class LevelType : ScriptableObject
    {
        [SerializeField] private List<Plank> _plankList;
        [SerializeField] private byte _levelID;

        private float _strong = 0f;
        public List<Plank> Planks => _plankList;
        public float AllEndurence => _strong;

        private void Awake()
        {      
            foreach (var plank in _plankList)
            {
                _strong += plank.GetEndurence();
            }
        }
    }
}
