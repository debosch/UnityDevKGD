using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Event { 

   [CreateAssetMenu(fileName = "Event",menuName = "Event")]
    public class ScriptableEvent : ScriptableObject
    {

        private List<Action> listeners;

        public void AddListener (Action action) {
            if (listeners = null) {
                listeners = new List<Action>();

            }

            if(listeners.IndexOf(action) == -1) {
                listeners.Add(action);
            }
        }

        public void RemoveListener(Action action)
        {
            if (listeners == null) {
                listeners = new List<Action>();
                return;
            }
            listeners.Remove(action);
        }
        public void Dispatch ()
        {
            if (_listeners == null) {
                return;
            }
            for (int i = 0; i< _listeners.Count; i++) {
                _listeners(i);
            }
        }
    }

 }


