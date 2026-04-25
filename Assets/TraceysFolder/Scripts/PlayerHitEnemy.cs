using UnityEngine;

public class PlayerHitEnemy : MonoBehaviour
{
    private TraceyGameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<TraceyGameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.LoseGame();
            }
        }
    }
}