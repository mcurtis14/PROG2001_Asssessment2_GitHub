using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public AudioClip collectSound;
    public string itemName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            GameManager.Instance.AddScore(itemName);
            gameObject.SetActive(false);
        }
    }
}