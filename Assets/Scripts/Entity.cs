using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float seeRange;
    [SerializeField] private float closeRange;
    float distance;
    float speed=0.3f;
    [SerializeField] private EntityType entityType;
    enum EntityType { MELEE,RANGED}
    
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var v = transform.position - player.position;
        v.y = 0;
        transform.rotation = Quaternion.LookRotation(v);

        float distance = Vector3.Distance(player.transform.position, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, player.transform.position - transform.position, out hit))
            if (distance<seeRange&&distance>closeRange)
                
                {
               
                transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x,transform.position.y, player.transform.position.z), (Time.deltaTime * speed));
        }
        if (distance<=closeRange) {
            Health player_health = player.GetComponent<Health>();

            player_health.CurrentHealth = player_health.CurrentHealth - 20;

        }

       
    }
}
