using UnityEngine;

public class PlatypusMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 120f;

    private Rigidbody rb;
    private Animator animator;

    private float moveInput;
    private float turnInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        // Important: stop physics from messing with rotation
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Input
        moveInput = Input.GetAxis("Vertical");     // W/S or Up/Down
        turnInput = Input.GetAxis("Horizontal");   // A/D or Left/Right

        // Animation
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(moveInput));
        }
    }

    void FixedUpdate()
    {
        if (rb == null) return;

        // --- ROTATION FIRST (important) ---
        float turn = turnInput * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        // --- MOVEMENT ---
        Vector3 moveDirection = transform.forward * moveInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);
    }
}