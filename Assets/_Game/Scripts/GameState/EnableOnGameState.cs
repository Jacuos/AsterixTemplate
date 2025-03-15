using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Game
{
    public class EnableOnGameState : MonoBehaviour
    {
        public List<GameState> states;

        void Awake()
        {
            GameStateManager.GameStateChanged += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            GameStateManager.GameStateChanged -= OnGameStateChanged;
        }

        public void OnGameStateChanged(GameState current)
        {
            gameObject.SetActive( states.Contains( current ) );
        }
    }
}