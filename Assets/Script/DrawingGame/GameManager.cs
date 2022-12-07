using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] attach;
    [SerializeField] GameObject[] linetrace;
    [SerializeField] GameObject winMenu;


    private bool fingerDown = false;

    private void OnMouseUp()
    {

        fingerDown = false;

        if (attach.Length <= 15)
        {
            for(int i = 0; i < linetrace.Length; i++)
            {
                Destroy(linetrace[i]);
            }

            winMenu.SetActive(true);
            FindObjectOfType<TouchDraw>().DesactiveDraw();
        }

    }


    void Update()
    {
        attach = GameObject.FindGameObjectsWithTag("Attach");
        linetrace = GameObject.FindGameObjectsWithTag("Line");
    }
}
