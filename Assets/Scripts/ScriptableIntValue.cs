using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName="New Score")]
public class ScriptableIntValue : ScriptableObject
{
    [SerializeField]
    public int save_score;
}
