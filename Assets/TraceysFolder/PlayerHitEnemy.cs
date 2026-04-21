using UnityEngine;

public class PlayerHitEnemy : MonoBehaviour
{
    private TraceyGameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<TraceyGameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (gameManager != null)
            {
                gameManager.LoseGame();
            }
        }
    }
}