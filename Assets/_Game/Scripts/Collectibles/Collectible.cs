using System;
using UnityEngine;

namespace _Game
{
    public class Collectible : MonoBehaviour
    {
        public CollectibleConfig config;


        private void OnTriggerEnter2D( Collider2D other )
        {
            if ( config.collectionLayer.Contains( other.gameObject.layer ) ) {
                PointsManager.Instance.AddPoints( config.points );
                SoundManager.Instance.PlayCoin();
                Destroy( gameObject );
            }
        }
    }
}