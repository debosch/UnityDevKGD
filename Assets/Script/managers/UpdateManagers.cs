using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

public class UpdateManagers : MonoBehaviour
{
    [SerializeField]
    private ScriptableEvent _updateEvent;

    private void Update()
    {
        _updateEvent.Dispatch();
    }

    private void FixedUpdate()
    {
        _fixedEvent.Dispatch();
    }
}
