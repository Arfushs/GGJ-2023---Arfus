using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform LevelTransfor;
    [Header("Redball")] 
    [SerializeField] private Transform door1;
    [SerializeField] private Transform door2;

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
        }
    }
    
}
