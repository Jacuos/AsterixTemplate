using UnityEngine;
using UnityEngine.UI;

namespace _Game
{
    [RequireComponent(typeof(Button))]
    public class ChangeGameStateButton : MonoBehaviour
    {
        public GameState newState;
        
        void Awake()
        {
            GetComponent<Button>( ).onClick.AddListener( OnButtonClicked );
        }

        void OnButtonClicked()
        {
            GameStateManager.Instance.SetGameState( newState );
        }
    }
}