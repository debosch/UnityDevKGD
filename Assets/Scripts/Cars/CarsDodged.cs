using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptTableIntValue {
    [CreateAssetMenu(fileName = "CarsDodged", menuName = "new CarsDodged")]
    public class CarsDodje : ScriptableObject {
        [SerializeField]
        private ScriptTableIntValue _score;

        public void Dodged(int dodgedScore) {
            _score.Score += dodgedScore;
        }
    }
}