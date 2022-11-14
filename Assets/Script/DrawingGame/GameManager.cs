using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] Attach;

    private bool isWin = false;
    void Update()
    {
        Attach = GameObject.FindGameObjectsWithTag("Attach");


        if (Attach.Length == 0 && isWin == false)
        {
            isWin = true;
            Debug.Log("ggwp!");
        }
    }
}
