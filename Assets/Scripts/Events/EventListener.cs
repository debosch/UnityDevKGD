using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Events {

    public class EventListener : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public event Action OnEventHappened = delegate { };

        private void OnEnable() {
            _someEvent.AddListener(EventHappaned);
        }

        private void OnDisable() {
            _someEvent.RemoveListener(EventHappaned);
        }

        private void EventHappaned() {
            OnEventHappened.Invoke();
        }

    }

}


