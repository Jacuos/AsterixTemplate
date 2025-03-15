using System;
using UnityEngine;

namespace _Game
{
    [RequireComponent(typeof(CanvasGroup))]
    public class CloseWindowAtStart : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;
        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
            _canvasGroup.SetActive( false );
        }
    }
}