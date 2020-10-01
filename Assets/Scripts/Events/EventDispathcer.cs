using System;
using UnityEngine;

namespace Events {
    public class EventDispathcer : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;
        
        public void Dispatch() {
            _someEvent.Dispatch();
        }
        private void update() {

        }
    }
}