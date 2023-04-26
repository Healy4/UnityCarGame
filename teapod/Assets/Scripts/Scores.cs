using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scores : MonoBehaviour
{
    public TextMeshProUGUI text;
    public NewControls controls;
 
    public GameObject player;
 
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        controls = player.GetComponent<NewControls>();
    }
 
    void Update()
    {
        if(controls != null)
        {
            text.text = $"Speed: {Math.Floor(controls.speed / 3.6)}";   //Math.Floor(controls.speed * 3.6)}";
        }
    }
}