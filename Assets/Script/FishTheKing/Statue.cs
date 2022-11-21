using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
    [SerializeField] GameObject winMenu;


    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        Debug.Log("GGWP!");
=======
        winMenu.SetActive(true);
>>>>>>> d3633147aa16fff22c1487b9db9c7c1c5f27ba18
    }

    private void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD

        if (collision.gameObject.CompareTag("Grappin"))
        {
            GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
=======
        if (collision.gameObject.CompareTag("Grappin"))
        {
        GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
        }
        else if(collision.gameObject.CompareTag("Trash"))
        {
            FindObjectOfType<Grappin>().DamageTaken(collision);
>>>>>>> d3633147aa16fff22c1487b9db9c7c1c5f27ba18
        }
    }

}
