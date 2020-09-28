using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Events {
    public class EventListeners : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public event Action OnEventHappened = delegate { };


        private void OnEnable() {
            _someEvent.AddListener(EventHappened);
        }

        private void Start() {

            _someEvent.AddListener(EventHappened);

        }
        private void OnDisable()
        {
            _someEvent.RemoveListeners(EventHappened);
        }
        private void EventHappened() {
            OnEventHappened();
        }

    }
}
