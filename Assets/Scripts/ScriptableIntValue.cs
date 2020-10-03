using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableIntValue", menuName = "ScriptableIntValue")]
public class ScriptableIntValue : ScriptableObject {
    
    [SerializeField]
    private int value = 0;
}