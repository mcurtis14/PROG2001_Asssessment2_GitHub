using UnityEngine;

public class DevilMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public float speed = 1.8f;
    public float waitTime = 1.5f;

    private Transform target;
    private Animator animator;

    private float waitTimer;
    private bool isWaiting = false;

    void Start()
    {
        animator = GetComponent<Animator>();

        if (pointA != null && pointB != null)
        {
            target = pointB;
        }
    }

    void Update()
    {
        if (pointA == null || pointB == null)
        {
            if (animator != null)
                animator.SetFloat("Speed", 0f);

            return;
        }

        //  WAITING LOGIC
        if (isWaiting)
        {
            waitTimer -= Time.deltaTime;

            if (animator != null)
                animator.SetFloat("Speed", 0f);

            if (waitTimer <= 0f)
            {
                isWaiting = false;

                // Switch target
                target = (target == pointA) ? pointB : pointA;
            }

            return;
        }

        //  MOVE TOWARDS TARGET
        Vector3 targetPosition = new Vector3(
            target.position.x,
            transform.position.y,
            target.position.z
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            speed * Time.deltaTime
        );

        // ROTATE TOWARDS TARGET
        Vector3 direction = targetPosition - transform.position;
        direction.y = 0f;

        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        //  ANIMATION CONTROL
        if (animator != null)
            animator.SetFloat("Speed", speed);

        //  REACHED TARGET → START WAITING
        if (Vector3.Distance(transform.position, targetPosition) < 0.2f)
        {
            isWaiting = true;
            waitTimer = waitTime;
        }
    }
}