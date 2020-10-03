using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName = "Score", menuName = "IntValue")]
    public class ScriptableIntValue : ScriptableObject {

        public int score;

    }
}