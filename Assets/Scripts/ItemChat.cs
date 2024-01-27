using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemChat : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemText;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    public void PlayText(string text)
    {
        itemText.text = text;
        anim.Play("ItemChatPlay");
        Invoke("RemoveText",4);
    }
    private void RemoveText()
    {
        anim.Play("ItemChatRemove");
    }
}
