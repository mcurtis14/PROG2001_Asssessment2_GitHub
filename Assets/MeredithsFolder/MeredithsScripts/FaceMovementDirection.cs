using UnityEngine;

public class FaceMovementDirection : MonoBehaviour
{
    public Rigidbody playerRb;
    public float rotationOffset = 0f;

    void Update()
    {
        Vector3 direction = playerRb.velocity;
        direction.y = 0f;

        if (direction.sqrMagnitude > 0.01f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = targetRotation * Quaternion.Euler(0f, rotationOffset, 0f);
        }
    }
}