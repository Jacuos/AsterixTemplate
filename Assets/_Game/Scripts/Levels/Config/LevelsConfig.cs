using UnityEngine;

namespace _Game
{
    [CreateAssetMenu(menuName = "Configs/LevelsConfig")]
    public class LevelsConfig : ScriptableObject
    {
        public int minPointsToWin;
    }
}