using System;
using UnityEngine;

namespace Game {
    
    [CreateAssetMenu(fileName = "Score", menuName = "Score")]
    public class ScriptableValue : ScriptableObject {
        public int score;
    }
}
