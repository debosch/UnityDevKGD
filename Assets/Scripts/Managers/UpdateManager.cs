using System.Collections;
using System.Collections.Generic;
using Events;
using UnityEngine;

namespace Game
{

    public class UpdateManager : MonoBehaviour
    {
        [SerializeField]
        private ScriptableEvent _updateEvent;

        [SerializeField]
        private ScriptableEvent _fixedEvent;
        // Update is called once per frame
        private void Update() {
            _updateEvent.Dispatch();
        }

        private void FixedUpdate()
        {
            _fixedEvent.Dispatch();
        }
    }
}
