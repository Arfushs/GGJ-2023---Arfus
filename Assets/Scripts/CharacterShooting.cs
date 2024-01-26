using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    public Gun currentGun;

    private bool canShoot;
    // Update is called once per frame
    void Update()
    {
        if (currentGun.current_ammo_count > 0)
            canShoot = true;
        else
            canShoot = false;
        
        if (canShoot && Input.GetMouseButtonDown(0))
        {
            currentGun.Shoot();
        }

        if (currentGun.current_ammo_count != currentGun.MAX_AMMO_COUNT && Input.GetKeyDown(KeyCode.R))
        {
            
            currentGun.Reload();
        }
        
    }
}
