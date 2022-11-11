using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void ButtonGrab()
    {
        FindObjectOfType<Grappin>().ChangeDirection();
    }
}
