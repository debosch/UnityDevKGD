using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CarsSettings {
    [CreateAssetMenu(fileName = "CarsSettings", menuName = "CarsSettings")]
    public class CarsSettings : ScriptableObject {
        [SerializeField]
        private int _dodgedScore;
    }
}
