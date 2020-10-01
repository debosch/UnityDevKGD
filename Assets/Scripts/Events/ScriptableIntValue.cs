using UnityEngine;

namespace Game
{

    [CreateAssetMenu(fileName = "Score", menuName = "Game/Score")]
    public class ScriptableIntValue : ScriptableObject {
        public int score;
    }
}