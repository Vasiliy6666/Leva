using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningDoor : MonoBehaviour
{
    public Key key;
    public float q;

    private void Update()
    {
        if (key.taken == true)
        {
            transform.rotation = Quaternion.Euler(0f,0f,q);
        }
    }
}
