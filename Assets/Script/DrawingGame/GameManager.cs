using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] Attach;

    private void OnMouseUp()
    {

        if (Attach.Length <= 15)
        {
         
            Debug.Log("ggwp!");
        }
    }

    void Update()
    {
        Attach = GameObject.FindGameObjectsWithTag("Attach");
    }
}
