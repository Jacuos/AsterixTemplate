using UnityEngine;

namespace _Game
{
    public class Obstacle : MonoBehaviour
    {
        public ObstacleConfig config;


        private void OnCollisionEnter2D( Collision2D other )
        {
            if ( config.hitLayer.Contains( other.gameObject.layer ) ) {
                ObstaclesManager.Instance.AddHit();
            }
        }
    }
}