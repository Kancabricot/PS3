using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] Attach;
    [SerializeField] GameObject WinMenu;
    [SerializeField] GameObject FxDraw;

    private bool fingerDown = false;

    private void OnMouseUp()
    {
        FxDraw.SetActive(false);
        fingerDown = false;

        if (Attach.Length <= 15)
        {
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
        Attach = GameObject.FindGameObjectsWithTag("Attach");

        if (fingerDown == true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            FxDraw.gameObject.transform.position = position;
        }
    }
}
