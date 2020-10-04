﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Events {

    [CreateAssetMenu(fileName = "New Event", menuName = "Event")]
    public class ScriptableEvent : ScriptableObject {

        private List<Action> _listeners;

        public void AddListener(Action action) {
            if (_listeners == null) {
                _listeners = new List<Action>();
            }

            if (_listeners.IndexOf(action) == -1) {
                _listeners.Add(action);
            }
        }

        public void RemoveListener(Action action) {
            if (_listeners == null || _listeners.IndexOf(action) == -1) {
                return;
            }

            _listeners.Remove(action);
        }

        public void Dispatch() {
            if (_listeners == null) {
                return;
            }

            for (int i = 0; i < _listeners.Count; ++i) {
                _listeners[i]();
            }
        }
    }
}
