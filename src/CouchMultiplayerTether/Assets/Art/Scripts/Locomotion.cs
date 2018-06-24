﻿using UnityEngine;

public class Locomotion : MonoBehaviour
{
    Rigidbody2D _rb;
    float speed = 15f;

    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var tmpSpeed = Vector2.zero;

        if (Input.GetKey(left))
        {
            tmpSpeed = Vector2.left * Time.deltaTime * speed;
        }
        else if (Input.GetKey(right))
        {
            tmpSpeed = Vector2.right * Time.deltaTime * speed;
        }

        if (tmpSpeed != Vector2.zero)
        {
            _rb.AddForce(tmpSpeed, ForceMode2D.Impulse);
        }
    }
}
