using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGrab : MonoBehaviour
{
    public void GrabButton()
    {
        FindObjectOfType<ChainMovement>().ChangeDirection();
    }
}
