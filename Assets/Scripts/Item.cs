using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ID;
    public string text;
    private ItemChat itemChat;
    private GameManager _gameManager;
    private void Awake()
    {
        itemChat = FindObjectOfType<ItemChat>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
               Inventory playerInv = other.GetComponent<Inventory>();
               itemChat.PlayText(text);
               playerInv.GetItem(ID);
               _gameManager.TriggerEvent(ID);
               Destroy(gameObject);
        }
    }
}
