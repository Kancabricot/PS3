using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] Transform target;

    private void FixedUpdate()
    {
        transform.LookAt(target, Vector3.left);
    }
}
