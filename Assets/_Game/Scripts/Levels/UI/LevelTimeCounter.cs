using System;
using TMPro;
using UnityEngine;

namespace _Game
{
    public class LevelTimeCounter : MonoBehaviour
    {
        public TextMeshProUGUI label;

        void Update()
        {
            label.text = "" + String.Format("{0:0.0}", Time.time - LevelManager.Instance.LevelStartTimestamp);
        }
    }
}