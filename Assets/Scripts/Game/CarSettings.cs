using UnityEngine;

namespace Game {
    [CreateAssetMenu(fileName = "CarSettings", menuName = "Car/CarSettings")]
    public class CarSettings : ScriptableObject {
        public int dodgeScore;
    }
}