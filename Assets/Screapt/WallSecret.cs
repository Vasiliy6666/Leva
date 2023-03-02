using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSecret : MonoBehaviour
{
    public Key key;

    private BoxCollider2D _boxCollider2D;

    private void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (key.isTrigged == true)
        {
            _boxCollider2D.isTrigger = true;
        }
    }
}
