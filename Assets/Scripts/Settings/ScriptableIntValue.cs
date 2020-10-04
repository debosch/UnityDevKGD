using UnityEngine;

namespace Game {

    [CreateAssetMenu(fileName = "NewScriptableIntValue", menuName = "ScriptableIntValue")]
    public class ScriptableIntValue : ScriptableObject {

        [SerializeField]
        private int score = 0;
    }
}
