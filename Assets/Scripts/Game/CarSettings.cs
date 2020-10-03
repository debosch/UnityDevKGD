using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CarSettings {

    [CreateAssetMenu(fileName = "Score", menuName = "CurrentScore")]
    public class CarSettings : ScriptableObject {
        [SerializeField]
        private int _dodgeScore = 0;
    }

}
