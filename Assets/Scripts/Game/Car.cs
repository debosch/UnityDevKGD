using Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {

    public class Car : MonoBehaviour {

        [SerializeField]
        private EventListener _updateEventListener;

        private void Awake() {
            _updateEventListener.OnEventHappened += Move;
            _updateEventListener.OnEventHappened += Die;
        }

        private void Move() {
            Debug.Log("Move");
        }

        private void Die() {
            Debug.Log("Die");
        }


    }

}