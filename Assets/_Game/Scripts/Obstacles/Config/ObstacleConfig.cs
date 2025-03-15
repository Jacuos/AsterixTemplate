using UnityEngine;

namespace _Game
{
    [CreateAssetMenu(menuName = "Configs/ObstacleConfig")]
    public class ObstacleConfig : ScriptableObject
    {
        public LayerMask hitLayer;
    }
}