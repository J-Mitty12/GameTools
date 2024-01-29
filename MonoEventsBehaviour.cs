using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, validateEvent;
    public float holdTime;
    private float speed = 3f;
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnValidate()
    {
        validateEvent.Invoke();
    }

    private void OnEnable()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;
    }

    private void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();

        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);

        for (int i = 0; i < numExit; i++)
        {
            ParticleSystem.Particle p = enter[i];
            p.startColor = new Color32(0, 255, 0, 255);
            exit[i] = p;
        }
        
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    }
} 
