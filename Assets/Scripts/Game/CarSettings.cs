using UnityEngine;


namespace Game {

    [CreateAssetMenu(fileName = "CarSettings", menuName = "CarSettings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        private int _dodgeScore;

    }
}
