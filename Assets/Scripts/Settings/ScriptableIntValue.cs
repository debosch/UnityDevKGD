using UnityEngine;

namespace Settings {

    [CreateAssetMenu(fileName = "NewScriptableIntValue", menuName = "ScriptableIntValue")]
    public class ScriptableIntValue : ScriptableObject {

        [SerializeField]
        private int _score;
    }
}
