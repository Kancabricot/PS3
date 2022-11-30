using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoFTK : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
        FindObjectOfType<ChainMovement>().StartGame();
    }
}
