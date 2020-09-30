using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName ="Current score", menuName ="Current Score")]
    public class ScriptableIntValue : ScriptableObject {

        public int score;
    }
}
