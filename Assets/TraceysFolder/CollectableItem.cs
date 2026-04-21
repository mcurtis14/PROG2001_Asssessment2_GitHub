using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public TraceyGameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.Collect();
            }

            Destroy(gameObject);
        }
    }
}