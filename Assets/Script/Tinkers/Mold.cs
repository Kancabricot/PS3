using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mold : MonoBehaviour
{
    private int bronzeIndex = 0;
    private GameObject[] bronzeMelt;


    private void Start()
    {
        bronzeMelt = GameObject.FindGameObjectsWithTag("BronzeMelt");
        Debug.Log(bronzeMelt.Length);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BronzeMelt"))
        {
            bronzeIndex += 1;
        }
    }

    public bool IsWin()
    {
        if(bronzeIndex > bronzeMelt.Length / 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
