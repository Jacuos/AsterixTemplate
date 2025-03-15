using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game
{
    public class Bootstrapper : MonoBehaviour
    {
        [Scene]
        public int coreScene;
        [Scene]
        public int[] scenesToLoad;
        [Scene]
        public int sceneToActivate;
        public CanvasGroup loadingScreen;

        private async void Awake()
        {
            loadingScreen.SetActive( true );
            await LoadGame();
            SetSceneActive();
            loadingScreen.DOFade( 0, 1 ).OnComplete( () =>
            {
                loadingScreen.SetActive( false );
                Destroy( loadingScreen.transform.parent.gameObject );
                Destroy( gameObject );
            } );
        }

        private async Awaitable LoadGame()
        {
            await SceneManager.LoadSceneAsync( coreScene, LoadSceneMode.Additive );
            foreach ( var scene in scenesToLoad ) {
                await SceneManager.LoadSceneAsync( scene, LoadSceneMode.Additive );
            }
        }

        void SetSceneActive()
        {
            var scene = SceneManager.GetSceneByBuildIndex( sceneToActivate );
            SceneManager.SetActiveScene( scene );
        }
    }
}