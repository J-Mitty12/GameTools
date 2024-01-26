using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Attributes/Attack")]
public class PlayerAttack : ScriptableObject
{
    public UnityEvent onEventRaised;

    public PlayerAttack onPlayerRaised;
    public PlayerAttack onPowerUpRaised;

    public void Raise()
    {
        onEventRaised.Invoke();
    }

    public void AddDamage(int damageAmount)
    {
        onPlayerRaised.Raise();
    }

    public void AddPowerUp(int attackIncrease)
    {
        onPowerUpRaised.Raise();
    }
    
}
