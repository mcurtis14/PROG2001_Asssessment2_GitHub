using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered water!");

            PlatypusMovement movement = other.GetComponent<PlatypusMovement>();
            if (movement != null)
            {
                movement.moveSpeed = 2f;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Left water!");

            PlatypusMovement movement = other.GetComponent<PlatypusMovement>();
            if (movement != null)
            {
                movement.moveSpeed = 5f;
            }
        }
    }
}