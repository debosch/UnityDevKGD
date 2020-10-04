using System;
using System.Collections.Generic;
using UnityEngine;
namespace ScriptableIntValue {

    [CreateAssetMenu(fileName = "CarSettings", menuName = "CarSettings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        private ScriptableIntValue _score;

        public void Dodged(int dodgedScore) {
            _score.Score += dodgedScore;
        }
    }
}