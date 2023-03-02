using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speak : MonoBehaviour
{
    public int damageSpeaks;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() is {} player)
        {
            player.health -= damageSpeaks;
        }
    }
}
