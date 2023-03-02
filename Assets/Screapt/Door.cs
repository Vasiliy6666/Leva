using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   
    public float q;

    public void UpdateState()
    {
        transform.rotation = Quaternion.Euler(0f,0f,q);
    }
}
