using UnityEngine;

public class PlatypusMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    public float acceleration = 8f;
    public float deceleration = 10f;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;
    private Vector3 currentVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 inputDirection = new Vector3(horizontal, 0f, vertical).normalized;

        // Smooth acceleration / deceleration
        if (inputDirection.magnitude > 0.1f)
        {
            currentVelocity = Vector3.Lerp(currentVelocity, inputDirection * moveSpeed, acceleration * Time.fixedDeltaTime);

            // Rotate toward movement
            Quaternion targetRotation = Quaternion.LookRotation(inputDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
        else
        {
            currentVelocity = Vector3.Lerp(currentVelocity, Vector3.zero, deceleration * Time.fixedDeltaTime);
        }

        rb.MovePosition(rb.position + currentVelocity * Time.fixedDeltaTime);
    }
}