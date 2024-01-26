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
    bool isAttacking = false;
    [SerializeField] private EntityType entityType;
    enum EntityType { MELEE,RANGED}
    [SerializeField ]private float damage ;
    [SerializeField] private float attack_speed ;

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
        if (distance<=closeRange&&!isAttacking) {

            DamageToPlayer();
            Invoke("ResetAttackSpeed", attack_speed);
            
        }

       
    }

    private void DamageToPlayer() 
    {
        Health player_health = player.GetComponent<Health>();
        Debug.Log(player_health.CurrentHealth);
        isAttacking = true;
        player_health.CurrentHealth = player_health.CurrentHealth - damage;
    }

    private void ResetAttackSpeed()
    {
        isAttacking = false;
    }
}
