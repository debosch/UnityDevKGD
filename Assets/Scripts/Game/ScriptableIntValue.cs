using UnityEngine;


namespace Game {

    [CreateAssetMenu(fileName = "IntValue", menuName = "IntValue/Score")]
    public class ScriptableIntValue : ScriptableObject{

        [SerializeField]
        private int _score;

    }
}

