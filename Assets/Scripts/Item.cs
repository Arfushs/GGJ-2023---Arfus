using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ID;

    

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Inventory playerInv = other.GetComponent<Inventory>();
                playerInv.GetItem(ID);
                Destroy(gameObject);
            }
        }
    }
}
