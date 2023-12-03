using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AIBot : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _computerSpeed;
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var movingVector =  new Vector3(transform.position.x, _ball.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, movingVector, _computerSpeed * Time.deltaTime);
    }
}
