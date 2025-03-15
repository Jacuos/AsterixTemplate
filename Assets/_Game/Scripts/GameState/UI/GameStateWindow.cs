using UnityEngine;

namespace _Game
{
    [RequireComponent(typeof(CanvasGroup))]
    public class GameStateWindow : MonoBehaviour
    {
        public GameState myState;
        private CanvasGroup _canvasGroup;
        
        void OnEnable()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
            GameStateManager.GameStateChanged += OnGameStateChanged;
            OnGameStateChanged(GameStateManager.Instance.CurrentGameState);
        }

        void OnDisable()
        {
            GameStateManager.GameStateChanged -= OnGameStateChanged;
        }

        public void OnGameStateChanged(GameState current)
        {
            _canvasGroup.SetActive(current == myState);
        }
    }
}