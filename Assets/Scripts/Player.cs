using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    public float speed;
    public int health;
    public float rotationSpeed;
    
    private Animator _animator;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Move();
        Death();
    }
    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        var nextPosition = transform.up * (speed * Time.deltaTime * vertical);
        _animator.SetBool("Run", nextPosition != Vector3.zero);

        transform.position += nextPosition;
        transform.Rotate(0, 0, -horizontal * rotationSpeed * Time.deltaTime);
    }

    private void Death()
    {
        if (health < 1)
        {
            SceneManager.LoadScene(6); 
        }
    }
}
