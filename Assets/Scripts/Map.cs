using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject mapButton;
    public bool isTrigged;

    private void Start()
    {
        mapButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isTrigged)
        {
            gameObject.SetActive(false);
            mapButton.SetActive(true);
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
