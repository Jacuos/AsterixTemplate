using System;
using TMPro;
using UnityEngine;

namespace _Game
{
    public class PointsCounter : MonoBehaviour
    {
        public TextMeshProUGUI label;
        public LevelsConfig levelsConfig;

        private void OnEnable()
        {
            PointsManager.PointsChanged += OnPointsChanged;
        }

        private void OnDisable()
        {
            PointsManager.PointsChanged -= OnPointsChanged;
        }

        void OnPointsChanged(int pts)
        {
            label.text = "" + pts + "/" + levelsConfig.minPointsToWin;
        }
    }
}