using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game { 

    public class UpdateManager : MonoBehaviour {

        [SerializeField]
        private ScriptableEvent updateEvent;


        private void Update() {
            updateEvent.Dispatch();
        }

    }
}
