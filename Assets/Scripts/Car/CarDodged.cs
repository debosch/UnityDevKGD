using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableIntValue {

    [CreateAssetMenu(fileName = "CarDodged", menuName = "new CarDodged")]
    public class CarDodged : ScriptableObject {
        [SerializeField]
        private ScriptableIntValue _score;

        public void Dodged(int dodgedScore) {
            _score.Score += dodgedScore;
        }
    }
}
