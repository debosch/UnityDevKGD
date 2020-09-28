using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game
{
    public class Car : MonoBehaviour
    {
        [SerializeField]
        private EventListeners _updaterEventListener;

        private void Awake()
        {
            _updaterEventListener.OnEventHappened += Move;
        }


        private void Move()
        {
            Debug.Log("Move");
        }
    }

}
