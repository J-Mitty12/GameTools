using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerExit(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
