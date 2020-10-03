using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Value {

    [CreateAssetMenu(fileName = "Score", menuName = "Score")]
    public class ScriptableIntValue : ScriptableObject {
        public int score = 0;
    }
}
