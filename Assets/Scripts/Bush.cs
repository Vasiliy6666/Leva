using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Bush : MonoBehaviour
{
    private bool isTrigged;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigged)
        {
           
        } 
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        isTrigged = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isTrigged = false;
    }
}
