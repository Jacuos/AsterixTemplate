using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game
{
    public class ExitGameplayInput : MonoBehaviour
    {
        private InputAction _cancelAction;

        void Awake()
        {
            _cancelAction = InputSystem.actions.FindAction( InputActionKeys.Cancel );
        }

        void Update()
        {
            if ( GameStateManager.Instance.CurrentGameState == GameState.MainMenu )
                return;
            if ( _cancelAction.IsPressed() && _cancelAction.WasPressedThisFrame() )
                GameStateManager.Instance.SetGameState( GameState.MainMenu );
        }
    }
}