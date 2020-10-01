using UnityEngine;

namespace Game {
    
    [CreateAssetMenu(fileName = "CurrentStore", menuName = "Value/CurrentStore")]
    public class ScriptableIntValue : ScriptableObject {
        public int currentStore;
    }
}