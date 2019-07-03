﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rigb2d;
    private float moveInput;
    private float speed = 10f;


    void Start()
    {
        rigb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

            moveInput = Input.GetAxis("Horizontal");
            rigb2d.velocity = new Vector2(moveInput * speed, rigb2d.velocity.y);


    }
}
