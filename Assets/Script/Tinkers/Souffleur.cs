using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Souffleur : MonoBehaviour
{


    private void OnMouseDown()
    {
        transform.localScale = new Vector3(1, 0.2f, 1);
        FindObjectOfType<Cauldron>().IncreaseHeat();
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1, 0.7f, 1);
    }
}
