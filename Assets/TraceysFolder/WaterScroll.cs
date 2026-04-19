using UnityEngine;

public class WaterFlow : MonoBehaviour
{
    public float flowSpeedX = 0.05f;
    public float flowSpeedY = 0.02f;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offsetX = Time.time * flowSpeedX;
        float offsetY = Time.time * flowSpeedY;

        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}