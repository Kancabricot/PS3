using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    private bool isGoDown = true;
    [SerializeField] float speed = 5;
    [SerializeField] float rotationSpeed = 5;
    private int life = 3;
    private bool isStatue = false;
    private GameObject Statue;
    private bool isTaken = false;

    void Update()
    {
        if(isGoDown == true)
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, -speed);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, speed);
        }

        if(isTaken == true)
        {
            Statue.GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Trash"))
        {
            life -= 1;
            Destroy(collision.gameObject);

            GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
            if (isTaken == true)
            {
                Statue.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
            }

            if (life <= 0)
            {
                Debug.Log("GameOver");
            }
        }else if (collision.gameObject.CompareTag("Floor"))
        {
            life -= 1;
           
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0),ForceMode.Impulse);
            if (isTaken == true)
            {
                Statue.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0), ForceMode.Impulse);
            }

            if (life <= 0)
            {
                Debug.Log("GameOver");
            }
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            isStatue = true;
            Statue = collision.gameObject;
        }
    }

    public void ChangeDirection()
    {
        if(isStatue == true)
        {
            isTaken = true;
        }
        isGoDown = false;
    }
}
