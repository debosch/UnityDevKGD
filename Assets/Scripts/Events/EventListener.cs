using System;
using UnityEngine;

namespace Events {
    
    public class EventListener : MonoBehaviour {
        
        [SerializeField] private ScriptableEvent _someEvent;

        public event Action onEventHappened = delegate { };

        private void OnEnable() {
            _someEvent.AddListener(EventHappened);
        }

        private void OnDisable() {
            _someEvent.RemoveListener(EventHappened);
        }

        private void EventHappened() {
            onEventHappened.Invoke();
        }

        // void Start() {
        //     _someEvent.AddListener(SomeMethod);
        // }

        // private void SomeMethod() {
        //     //logic
        //         Debug.Log("!!!!");
        // }

        // Update is called once per frame
        void Update() { }
    }
}