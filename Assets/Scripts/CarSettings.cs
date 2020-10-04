using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type Car", menuName = "New Type Car", order = 51)]
public class CarSettings : ScriptableObject
{
    [SerializeField]
    private string name;
    [SerializeField]
    private int dodgeScore;
}
