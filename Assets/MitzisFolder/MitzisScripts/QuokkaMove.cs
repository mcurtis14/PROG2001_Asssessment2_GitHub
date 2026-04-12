using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuokkaMove : MonoBehaviour
{
    private Rigidbody rb;
    private float moveX;
    private float moveY;
    public float moveSpeed = 17;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    public void OnMove(InputValue moveValue)
    {
        Vector2 moveVector = moveValue.Get<Vector2>();
        moveX = moveVector.x;
        moveY = moveVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX, 0.0f, moveY);
        rb.AddForce(movement * moveSpeed);
    }
}
