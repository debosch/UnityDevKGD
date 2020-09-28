using System;
using System.Collections.Generic;
using UnityEngine;
namespace Events {

    public class EventListeners : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public event Action OnEventHappened = delegate { }; //delegate { } - уверены что не null при случае проверки и запуска event

        private void OnEnable() {
            _someEvent.AddListener(EventHappened);
        }

        private void OnDisable() {
            _someEvent.RemoveListener(EventHappened);
        }

        private void EventHappened() {
            OnEventHappened.Invoke();
        }
    }
}
