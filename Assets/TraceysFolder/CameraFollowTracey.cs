using UnityEngine;

public class CameraFollowTracey : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 4, -5);
    public float smoothSpeed = 5f;
    public Vector3 lookOffset = new Vector3(0, 1, 0);

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(player.position + lookOffset);
    }
}