using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasseGaucheExtreme : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Extreme Gauche");
    }
}
