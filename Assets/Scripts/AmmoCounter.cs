using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    [SerializeField] private Image ammoSymbol;
    [SerializeField] private TextMeshProUGUI ammoCount;
    [SerializeField] private CharacterShooting player;

    // Update is called once per frame
    void Update()
    {
        ammoSymbol.sprite = player.currentGun.ammoSymbol;
        string ammo = player.currentGun.current_ammo_count.ToString()+ "/"+ player.currentGun.MAX_AMMO_COUNT.ToString();
        ammoCount.text = ammo;
        
    }
}
