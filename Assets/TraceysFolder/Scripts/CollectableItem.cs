using UnityEngine;
using System.Collections;

public class CollectableItem : MonoBehaviour
{
    private TraceyGameManager gameManager;
    private bool collected = false;

    public float rotateSpeed = 50f;
    public float popScale = 1.5f;
    public float popTime = 0.2f;

    void Start()
    {
        gameManager = FindObjectOfType<TraceyGameManager>();
    }

    void Update()
    {
        if (!collected)
        {
            transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true;

            if (gameManager != null)
            {
                gameManager.Collect();
            }

            StartCoroutine(CollectEffect());
        }
    }

    IEnumerator CollectEffect()
    {
        Vector3 startScale = transform.localScale;
        Vector3 endScale = startScale * popScale;

        float timer = 0f;

        while (timer < popTime)
        {
            transform.localScale = Vector3.Lerp(startScale, endScale, timer / popTime);
            timer += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }
}