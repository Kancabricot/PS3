using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] int Distance = 1;

    [SerializeField] float speed = 1;

    private bool canMove = true;


    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3( 0, -speed, 0);
    }

    public void GoRight()
    {
        if (transform.position.x < 2 && canMove == true)
        {
            transform.position = new Vector3(transform.position.x + Distance, transform.position.y, transform.position.z);
        }
    }

    public void GoLeft()
    {
        if (transform.position.x > -2 && canMove == true)
        {
            transform.position = new Vector3(transform.position.x + -Distance, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(canMove == true)
        {
            canMove = false;
            FindObjectOfType<GamemanagerTettris>().NewObject();
        }

    }
}
