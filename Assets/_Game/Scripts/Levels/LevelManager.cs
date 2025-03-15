using System;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game
{
    public class LevelManager : Manager<LevelManager>
    {
        public static Action NewLevelLoaded;
        public static Action MainMenuLoaded;
        
        [Scene]
        public int gameplayScene;
        [Scene]
        public int mainMenuScene;
        public LevelsConfig levelsConfig;

        public float LevelStartTimestamp
        {
            get;
            private set;
        }
        
        void OnEnable()
        {
            GameStateManager.GameStateChanged += OnGameStateChanged;   
        }

        void OnDisable()
        {
            GameStateManager.GameStateChanged -= OnGameStateChanged;    
        }
        
        private void OnGameStateChanged( GameState current )
        {
           if(current == GameState.GamePlay)
               LoadLevel();
           else if ( current == GameState.MainMenu )
               LoadMenu();
        }
        async Awaitable LoadLevel()
        {
            SceneManager.UnloadSceneAsync( SceneManager.GetActiveScene());
            await SceneManager.LoadSceneAsync( gameplayScene , LoadSceneMode.Additive);
            SceneManager.SetActiveScene( SceneManager.GetSceneByBuildIndex( gameplayScene ) );
            NewLevelLoaded?.Invoke();
            LevelStartTimestamp = Time.time;
        }
        async Awaitable LoadMenu()
        {
            SceneManager.UnloadSceneAsync( SceneManager.GetActiveScene());
            await SceneManager.LoadSceneAsync( mainMenuScene , LoadSceneMode.Additive);
            SceneManager.SetActiveScene( SceneManager.GetSceneByBuildIndex( mainMenuScene ) );
            MainMenuLoaded?.Invoke();
        }
    }
}