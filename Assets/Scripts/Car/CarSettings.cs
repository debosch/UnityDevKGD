using System;
using System.Collections.Generic;
using UnityEngine;
namespace CarSettings {

    [CreateAssetMenu(fileName = "CarSettings", menuName = "CarSettings")]
    public class CarSettings : ScriptableObject {

        [SerializeField]
        public int dodjeScor = 0;
    }
}