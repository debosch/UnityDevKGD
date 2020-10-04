using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName = "NewCarSettings", menuName = "CarSettings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        private int _dodgeScore = 0;
    }
}
