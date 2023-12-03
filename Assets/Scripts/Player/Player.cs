using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private Vector2 _movingVector;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        HandleInput();
        Move();
    }

    private void HandleInput()
    {
        var vertical = Input.GetAxis("Vertical") * Time.fixedDeltaTime;
        _movingVector = new Vector2(0, vertical);
    }

    private void Move()
    {
        _rigidbody.velocity = _movingVector * _movingSpeed;
    }
}
