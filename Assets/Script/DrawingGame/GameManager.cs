using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] attach;
    [SerializeField] GameObject[] linetrace;
    [SerializeField] GameObject WinMenu;
    [SerializeField] GameObject FxDraw;

    private bool fingerDown = false;

    private void OnMouseUp()
    {
        FxDraw.SetActive(false);
        fingerDown = false;

        if (attach.Length <= 15)
        {
            for(int i = 0; i < linetrace.Length; i++)
            {
                Destroy(linetrace[i]);
            }

            WinMenu.SetActive(true);
        }

    }

    private void OnMouseDown()
    {
        FxDraw.SetActive(true);
        fingerDown = true;
    }

    void Update()
    {
        attach = GameObject.FindGameObjectsWithTag("Attach");
        linetrace = GameObject.FindGameObjectsWithTag("Line");

        if (fingerDown == true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            FxDraw.gameObject.transform.position = position;
        }
    }
}
