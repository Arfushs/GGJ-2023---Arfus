using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float MAX_HEALTH;
    private float current_health;

    private void Awake()
    {
        current_health = MAX_HEALTH;
    }

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
