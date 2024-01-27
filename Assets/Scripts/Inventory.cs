using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, bool> allItems = new Dictionary<string, bool>();

    private void Awake()
    {
        allItems.Add("key_0",false);
        allItems.Add("key_1",false);
        allItems.Add("key_2",false);
        allItems.Add("key_3",false);
        allItems.Add("red_ball",false);
        
    }

    public bool CheckHasItItem(string ID)
    {
        return allItems[ID];
    }

    public void GetItem(string ID)
    {
        allItems[ID] = true;
    }
}
