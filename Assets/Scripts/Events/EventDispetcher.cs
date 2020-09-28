using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Events { 
    
    public class EventDispetcher : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public void Dispatch() {
            _someEvent.Dispatch();
        }
    }
}

