using UnityEngine;

public class WaterWave : MonoBehaviour
{
    public float waveHeight = 0.03f;
    public float waveSpeed = 1.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * waveSpeed) * waveHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}