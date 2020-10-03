using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events {
    
    public class EventListener : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _sampleEvent;

        public event Action OnEventHappened = delegate {};

        private void OnEnable() {
            _sampleEvent.AddListener(EventHandler);
        }

        private void OnDisable() {
            _sampleEvent.RemoveListener(EventHandler);
        }

        private void EventHandler() {
            OnEventHappened.Invoke();
        }


    }

}

