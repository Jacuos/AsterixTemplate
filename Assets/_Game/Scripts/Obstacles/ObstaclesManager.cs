using System;

namespace _Game
{
    public class ObstaclesManager : Manager<ObstaclesManager>
    {
        public static Action<int> PlayerHit;

        public int Hits
        {
            get;
            private set;
        }

        private void OnEnable()
        {
            GameStateManager.GameStateChanged += OnGameStateChanged;
        }

        private void OnDisable()
        {
            GameStateManager.GameStateChanged -= OnGameStateChanged;
        }
        
        private void OnGameStateChanged( GameState current )
        {
            if ( current != GameState.GamePlay )
                return;
            ResetHits();
        }

        public void ResetHits()
        {
            Hits = 0;
            PlayerHit?.Invoke( 0 );
        }

        public void AddHit()
        {
            Hits++;
            PlayerHit?.Invoke( Hits );
        }
    }
}