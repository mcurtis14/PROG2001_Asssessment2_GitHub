using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 7f, -6f);
    public Vector3 lookOffset = new Vector3(0f, 1.5f, 0f);

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
            transform.LookAt(player.position + lookOffset);
        }
    }
}