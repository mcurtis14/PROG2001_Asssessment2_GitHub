using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuokkaControl : MonoBehaviour
{
    public GameObject animal;
    [SerializeField] float moveValue;
    [SerializeField] Vector3 sizeChange;
    private Vector3 startPosition;


    public void MoveRight()
    {
        animal.transform.position = new Vector3(
            animal.transform.position.x + moveValue,
            animal.transform.position.y,
            animal.transform.position.z
            );
    }

    public void MoveLeft()
    {
        animal.transform.position = new Vector3(
            animal.transform.position.x - moveValue,
            animal.transform.position.y,
            animal.transform.position.z
            );
    }


    public void MoveUp()
    {
        animal.transform.position = new Vector3(
            animal.transform.position.x,
            animal.transform.position.y + moveValue,
            animal.transform.position.z 
            );
    }

    public void MoveDown()
    {
        animal.transform.position = new Vector3(
            animal.transform.position.x,
            animal.transform.position.y - moveValue,
            animal.transform.position.z 
            );
    }


    public void ResetAnimal()
    {
        //animal.transform.position = Vector3.zero;// reset position to 0.0.0
        animal.transform.position = startPosition;
        animal.transform.localScale = Vector3.one;
    }


    void Start()
    {
        startPosition = new Vector3(
            animal.transform.position.x,
            animal.transform.position.y,
            animal.transform.position.z
            );
    }



}
