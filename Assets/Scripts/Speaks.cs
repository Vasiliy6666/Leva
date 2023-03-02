// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class Speaks : MonoBehaviour
// {
//     public int damageSpeaks;
//     private Animator _animator;
//
//     private void Start()
//     {
//         _animator = GetComponent<Animator>();
//     }
//
//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.GetComponent<Player>() is {} player)
//         {
//             player.health -= damageSpeaks;
//             _animator.SetBool("SpeaksAnimation");
//         }
//     }
// }
