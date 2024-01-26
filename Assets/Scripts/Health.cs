using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float MAX_HEALTH;
    private float current_health;

    public float MaxHealth
    {
        get => MAX_HEALTH;
        
    }

    public float CurrentHealth
    {
        get => current_health;
        set => current_health = value;
    }
}
