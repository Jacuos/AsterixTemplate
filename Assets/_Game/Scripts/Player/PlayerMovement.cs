using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        public PlayerConfig _config;
        
        private Vector2 _moveInputVector;
        private InputAction _moveAction;
        private Rigidbody2D _rigidbody2D;

        void Awake()
        {
            _moveAction = InputSystem.actions.FindAction( InputActionKeys.Move );
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            _moveInputVector = _moveAction.ReadValue<Vector2>();
        }

        private void FixedUpdate()
        {
            if ( GameStateManager.Instance.CurrentGameState != GameState.GamePlay ) {
                _rigidbody2D.linearVelocity = Vector2.zero;
                return;
            }
            _rigidbody2D.linearVelocity = _moveInputVector.normalized * _config.movementSpeed * Time.fixedDeltaTime;
        }
    }
}