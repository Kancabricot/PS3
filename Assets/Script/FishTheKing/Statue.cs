using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    [SerializeField] GameObject winMenu;


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("GGWP!");

        winMenu.SetActive(true);

    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Grappin"))
        {
            GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
        }

        if (collision.gameObject.CompareTag("Grappin"))
        {
        GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
        }
        else if(collision.gameObject.CompareTag("Trash"))
        {
            //FindObjectOfType<Grappin>().DamageTaken(collision);

        }
    }

}
