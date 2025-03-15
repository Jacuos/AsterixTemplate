using System;
using TMPro;
using UnityEngine;

namespace _Game
{
    public class HitsCounter : MonoBehaviour
    {
        public TextMeshProUGUI label;

        private void OnEnable()
        {
            ObstaclesManager.PlayerHit += OnPlayerHit;
        }

        private void OnDisable()
        {
            ObstaclesManager.PlayerHit -= OnPlayerHit;
        }

        void OnPlayerHit(int pts)
        {
            label.text = "" + pts;
        }
    }
}