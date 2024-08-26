using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool isTrigged;
    public GameObject keyButton;

    private void Start()
    {
        keyButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigged)
        {
            gameObject.SetActive(false);
            keyButton.SetActive(true);
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
