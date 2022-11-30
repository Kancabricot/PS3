using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    [SerializeField] GameObject winMenu;
    private bool istaken = false;

    private void OnTriggerEnter(Collider other)
    {
        winMenu.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grappin") && istaken == false)
        {
            istaken = true;
        GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
        FindObjectOfType<ChainMovement>().ChangeDirection();
        }
        else if(collision.gameObject.CompareTag("Trash"))
        {
            FindObjectOfType<Grappin>().DamageTaken(collision);
        }
    }

}
