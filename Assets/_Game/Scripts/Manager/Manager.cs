using UnityEngine;
using System.Collections;

namespace _Game
{
    public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = FindFirstObjectByType( typeof( T ) ) as T;
                if ( _instance == null ) {
                    Debug.LogError( "Did not find manager of type: " + typeof( T ) );
                }
                return _instance;
            }
            protected set
            {
                _instance = value;
            }
        }

        public static bool HasInstance
        {
            get { return _instance != null && !_instance.Equals( null ); }
        }
        
        protected virtual void Awake()
        {
            if ( Instance != null && Instance != this ) {
                Destroy( gameObject );
                return;
            }
            Instance = this as T;
        }
    }
}
