using UnityEngine;

namespace Settings {

    [CreateAssetMenu(fileName = "NewCarSettings", menuName = "CarSettings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        private int _dodgeScore;
    }
}
