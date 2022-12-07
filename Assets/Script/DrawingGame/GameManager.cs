using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] attach;
    [SerializeField] GameObject[] linetrace;
    [SerializeField] GameObject winMenu;
    [SerializeField] Image bar;
    [SerializeField] float maxDistance;


    private void Start()
    {
        attach = GameObject.FindGameObjectsWithTag("Attach");
        maxDistance = attach.Length;
    }

    private void OnMouseUp()
    {

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

        bar.fillAmount = attach.Length / maxDistance;
    }
}
