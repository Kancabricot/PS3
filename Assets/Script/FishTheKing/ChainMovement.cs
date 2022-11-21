using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainMovement : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;

    private bool isGoDown = true;
    [SerializeField] float speed = 5;
    [SerializeField] float rotationSpeed = 5;

    void Update()
    {
        if (isGoDown == true)
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, -speed);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, speed);
        }
    }

    public void ChangeDirection()
    {
        isGoDown = false;

        var transposer = vcam.GetCinemachineComponent<CinemachineFramingTransposer>();
        transposer.m_TrackedObjectOffset = new Vector3(0, 5, 0);
    }
}
