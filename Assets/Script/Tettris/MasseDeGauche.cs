using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasseDeGauche : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gauche");
    }
}
