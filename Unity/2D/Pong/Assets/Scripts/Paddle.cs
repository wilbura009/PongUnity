using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    
    private float _movement;

    private void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    private void Update()
    {
        _movement = Input.GetAxisRaw(isPlayer1 ? "Vertical" : "Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, _movement * speed);
    }

    public void Reset()
    {
       rb.velocity = Vector2.zero;
       transform.position = startPosition;
    }
}
