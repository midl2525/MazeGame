using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMovements : Sound
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        Vector2 acceleration = Input.acceleration;

        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        //Vector2 acceleration = new Vector2(x, y);

        _rigidbody.velocity = acceleration * _speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlaySound(Sounds[0]);
    }
}

