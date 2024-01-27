using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int MAX_AMMO_COUNT;
    public int current_ammo_count;
    public float damage;
    public Animator anim;
    public Sprite ammoSymbol;
    public Camera fpsCam;
    public float range;
    public LayerMask whatIsEnemy;
    private void Awake()
    {
        current_ammo_count = MAX_AMMO_COUNT;
        anim = GetComponent<Animator>();
    }

    public void Reload()
    {
        anim.SetTrigger("reload");
        current_ammo_count = MAX_AMMO_COUNT;
    }

    public void Shoot()
    {
        current_ammo_count -= 1;
        anim.SetTrigger("fire");
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out RaycastHit raycastHit, range,
                whatIsEnemy))
        {
            if (raycastHit.collider.CompareTag("Enemy"))
            {
                Health enemyH = raycastHit.collider.GetComponent<Health>();
                enemyH.CurrentHealth -= damage;
            }
                
        }
    }
}
