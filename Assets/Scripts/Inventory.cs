using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, bool> allItems = new Dictionary<string, bool>();

    private void Awake()
    {
        allItems.Add("key_red",false);
        allItems.Add("red_ball",false);
        allItems.Add("folder",false);
        
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
