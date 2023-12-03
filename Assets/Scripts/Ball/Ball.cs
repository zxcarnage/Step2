using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 _startBallDirection;
    [SerializeField] private float _ballSpeed;

    private Vector2 _currentBallDirection;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _currentBallDirection = _startBallDirection;
        LaunchBall();
    }

    private void LaunchBall()
    {
        _rigidbody.velocity = _currentBallDirection * _ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _currentBallDirection = Vector2.Reflect(_currentBallDirection, collision.contacts[0].normal);
        LaunchBall();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, _startBallDirection);
    }
}
