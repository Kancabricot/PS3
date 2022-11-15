using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TettrisInput : MonoBehaviour
{

    public void InputRight()
    {
        FindObjectOfType<Cube>().GoRight();
    }

    public void InputLeft()
    {
        FindObjectOfType<Cube>().GoLeft();
    }

}
