﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game
{
    public class UpdateManager : MonoBehaviour
    {
        [SerializeField]
        private ScriptableEvent _updateEvent;

        [SerializeField]
        private ScriptableEvent _fixedEvent;

        public void Update()
        {
            _updateEvent.Dispatch();
        }

        public void FixedUpdate()
        {
            _updateEvent.Dispatch();
        }
    }
}
