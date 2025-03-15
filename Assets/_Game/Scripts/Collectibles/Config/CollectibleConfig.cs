using UnityEngine;

namespace _Game
{
    [CreateAssetMenu(menuName = "Configs/CollectibleConfig")]
    public class CollectibleConfig : ScriptableObject
    {
        public int points;
        public LayerMask collectionLayer;
    }
}