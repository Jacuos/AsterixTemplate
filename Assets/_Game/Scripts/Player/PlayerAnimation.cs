using UnityEngine;

namespace _Game
{
    
    public class PlayerAnimation : MonoBehaviour
    {
        private const string idleValue = "Idle";
        private const string walkLeftValue = "WalkLeft";
        private const string walkRightValue = "WalkRight";
        private const string walkUpValue = "WalkUp";
        private const string walkDownValue = "WalkDown";
        
        private int IDLE = Animator.StringToHash( idleValue );
        private int WALK_LEFT = Animator.StringToHash(walkLeftValue);
        private int WALK_RIGHT = Animator.StringToHash(walkRightValue);
        private int WALK_UP = Animator.StringToHash(walkUpValue);
        private int WALK_DOWN = Animator.StringToHash( walkDownValue );
        
        private Animator _animator;
        private Rigidbody2D _rigidbody;

        void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _rigidbody = GetComponentInChildren<Rigidbody2D>();
        }

        void Update()
        {
            AnimateWalk();
        }

        void AnimateWalk()
        {
            Vector2 velocity = _rigidbody.linearVelocity;
            if(velocity.sqrMagnitude== 0)
                _animator.SetTrigger( IDLE );
            else if(velocity.y>0.01)
                _animator.SetTrigger( WALK_UP);
            else if(velocity.y<-0.01)
                _animator.SetTrigger( WALK_DOWN);
            else if(velocity.x > 0.01)
                _animator.SetTrigger( WALK_RIGHT );
            else if(velocity.x<-0.01)
                _animator.SetTrigger( WALK_LEFT );
        }
    }
}