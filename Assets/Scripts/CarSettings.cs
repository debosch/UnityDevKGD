using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type Car", menuName = "New Type Car")]
public class CarSettings : ScriptableObject
{
    [SerializeField]
    private int dodgeScore;
}
