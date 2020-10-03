using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events {

    public class EventDispatcher : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent _sampleEvent;

        public void Dispatch() {
            _sampleEvent.Dispatch();
        }


    }

}

