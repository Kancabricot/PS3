using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GGWP!");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touch something");
        if (collision.gameObject.CompareTag("Grappin"))
        {

        GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
        }
    }

}
