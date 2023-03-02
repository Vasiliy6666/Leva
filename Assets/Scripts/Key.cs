using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Door door;
    public bool isTrigged;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigged)
        {
            door.UpdateState();
            Destroy(gameObject);
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
