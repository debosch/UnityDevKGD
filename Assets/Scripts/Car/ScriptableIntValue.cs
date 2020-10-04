using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableIntValue {
    [CreateAssetMenu(fileName = "Score", menuName = "new Score")]
    public class ScriptableIntValue : ScriptableObject {
        [SerializeField]
        public int Score;
    }
}
