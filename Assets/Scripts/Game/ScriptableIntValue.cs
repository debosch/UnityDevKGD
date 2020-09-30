using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName = "score", menuName = "score")]
    public class ScriptableIntValue : ScriptableObject {

        public int score;

    }
}