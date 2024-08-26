using System;
using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;

public class Door : MonoBehaviour,IActiveObject
{
   
    public float q;

    public void UpdateState()
    {
        transform.rotation = Quaternion.Euler(0f,0f,q);
    }

    public bool Active(InventoryItem item)
    {
        if (item.name != "Key") return false;
        UpdateState();return true;

    }
}
