using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGift : MonoBehaviour
{
   public int bonusHealth;
   public Player player;
   
   private bool _isTrigged;
   
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.E) && _isTrigged)
      {
         player.health += bonusHealth;
         Destroy(gameObject);
      } 
   }
   private void OnTriggerEnter2D(Collider2D col)
   {
      _isTrigged = true;
   }
   private void OnTriggerExit2D(Collider2D other)
   {
      _isTrigged = false;
   }
}
