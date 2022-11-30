using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoTravelBoat : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<Boat>().OnStartGame();
        Destroy(gameObject);
    }
}
