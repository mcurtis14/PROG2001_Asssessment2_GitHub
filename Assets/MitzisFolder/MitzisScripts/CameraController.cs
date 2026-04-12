using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject quokka;
    private Vector3 offset;


    void Start()
    {
        offset = transform.position - quokka.transform.position;
    }


    void LateUpdate()
    {
        transform.position = quokka.transform.position + offset;
    }
}
