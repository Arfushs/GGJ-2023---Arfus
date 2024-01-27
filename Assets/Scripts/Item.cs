using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ID;
    public string text;
    private ItemChat itemChat;
    private void Awake()
    {
        itemChat = FindObjectOfType<ItemChat>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
               Inventory playerInv = other.GetComponent<Inventory>();
               itemChat.PlayText(text);
               playerInv.GetItem(ID);
               Destroy(gameObject);
        }
    }
}
