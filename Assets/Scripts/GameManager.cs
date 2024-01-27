using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform LevelTransfor;
    [Header("Redball")] 
    [SerializeField] private Transform door1;
    [SerializeField] private Transform door2;
    [Header("Red Key")]
    [SerializeField] private Transform door3;
    [SerializeField] private Transform door4;
    [Header("Folder")] 
    [SerializeField] private GameObject folderUI;
    [SerializeField] private Transform wall;
    private bool isFolderOpen = false;

    private void Update()
    {
        if(isFolderOpen && Input.GetKeyDown(KeyCode.E))
            folderUI.SetActive(false);
            
    }

    public void TriggerEvent(string ID)
    {
        switch (ID)
        {
            case "red_ball":
                door1.position = new Vector3(-25.2998f, -33.7630005f, 29.5769997f) + LevelTransfor.position;
                door1.rotation = Quaternion.Euler(new Vector3(0,42.5399933f,0));
                door2.position = new Vector3(-25.4759998f, -33.7630005f, 33.6870003f) + LevelTransfor.position;;
                door2.rotation = Quaternion.Euler(new Vector3(0,180f,0));
                break;
            
            case "key_red":
                door3.position = new Vector3(17.9099998f,-33.7630005f,16.0900002f) + LevelTransfor.position;
                door3.rotation = Quaternion.Euler(new Vector3(0,180.769989f,0));
                door4.position = new Vector3(17.1100006f,-33.7630005f,21.6399994f) + LevelTransfor.position;;
                door4.rotation = Quaternion.Euler(new Vector3(0,31.1999969f,0));
                break;
            
            case "folder":
                folderUI.SetActive(true);
                isFolderOpen = true;
                Destroy(wall.gameObject);
                break;
        }
    }
    
}
