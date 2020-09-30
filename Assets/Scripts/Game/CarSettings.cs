using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName ="Car Settings", menuName ="Car Settings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        private int _dodgeScore;
    }
}
