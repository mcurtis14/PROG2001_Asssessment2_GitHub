using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController_Lucy : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public AudioSource audioSource;
    public AudioClip pickupSound;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>(); 
         count = 0; 
         SetCountText();
         winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
    
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
       
        if (count >= 5)
        {
            winTextObject.SetActive(true);
        }
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3 (movementX,0.0f, movementY);  
        rb.AddForce(movement * speed);   
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            audioSource.PlayOneShot(pickupSound);
        other.gameObject.SetActive(false); 
        count = count + 1;  
        SetCountText();
        }
    }
}
