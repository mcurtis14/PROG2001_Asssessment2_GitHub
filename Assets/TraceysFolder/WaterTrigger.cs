using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public AmbienceSwitcher ambienceSwitcher;

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

            if (ambienceSwitcher != null)
            {
                ambienceSwitcher.EnterWater();
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

            if (ambienceSwitcher != null)
            {
                ambienceSwitcher.ExitWater();
            }
        }
    }
}