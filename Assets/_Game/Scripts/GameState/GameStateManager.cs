using System;

namespace _Game
{
    public class GameStateManager : Manager<GameStateManager>
    {
        public static Action<GameState> GameStateChanged;
        public GameState CurrentGameState
        {
            get;
            private set;
        }
        
        public GameState PreviousGameState
        {
            get;
            private set;
        }
        protected override void Awake()
        {
            base.Awake();
            CurrentGameState = GameState.None;
            PreviousGameState = GameState.None;
            SetGameState( GameState.MainMenu );
        }

        public void SetGameState(GameState newState)
        {
            PreviousGameState = CurrentGameState;
            CurrentGameState = newState;
            GameStateChanged?.Invoke( CurrentGameState );
        }
    }

    public enum GameState
    {
        None, MainMenu, GamePlay,GameOver
    }
}