using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    [SerializeField] float speed = 5;
    private Vector3 test;
    [SerializeField] GameObject wheel;

    void Update()
    {
        test = transform.forward * speed;

    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = test;

        //transform.eulerAngles = wheel.transform.eulerAngles;
        transform.eulerAngles = new Vector3(0, -wheel.transform.eulerAngles.y, 0);

    }
}
