using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Car setting", menuName = "Car setting")]
public class CarSettings : ScriptableObject {
    [SerializeField] 
    private int _dodgeScore; 
}
