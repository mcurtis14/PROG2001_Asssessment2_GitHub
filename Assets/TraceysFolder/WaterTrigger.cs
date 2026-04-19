using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public AmbienceSwitcher ambienceSwitcher;
    public AudioSource splashSound;

    public float waterSpeed = 2f;
    public float landSpeed = 5f;

    public float waterDrag = 3f;
    public float landDrag = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered water!");

            PlatypusMovement movement = other.GetComponent<PlatypusMovement>();
            if (movement != null)
            {
                movement.moveSpeed = waterSpeed;
            }

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.drag = waterDrag;
            }

            if (ambienceSwitcher != null)
            {
                ambienceSwitcher.EnterWater();
            }

            if (splashSound != null)
            {
                splashSound.Play();
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
                movement.moveSpeed = landSpeed;
            }

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.drag = landDrag;
            }

            if (ambienceSwitcher != null)
            {
                ambienceSwitcher.ExitWater();
            }
        }
    }
}