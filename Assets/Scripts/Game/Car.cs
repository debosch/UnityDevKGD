using System;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game {
    public class Car : MonoBehaviour {

        [SerializeField]
        private EventListeners _updateEventListeners;

        private void Awake() {
            _updateEventListeners.OnEventHappened += Move;
        }

        private void Move() {
            Debug.Log("Move");
        }
    }
}
