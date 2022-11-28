using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Levier : MonoBehaviour
{
    private bool isPokemon = false;
    [SerializeField] GameObject menuWin;

    public void BegenningLever()
    {
        transform.DOMoveY(transform.position.y -5.32f, 1f, false)
            .SetEase(Ease.OutQuad);
        
    }

    private void OnMouseDown()
    {
        isPokemon = true;
    }

    private void OnMouseUp()
    {
        isPokemon = false;
        transform.DOMoveY(transform.position.y - transform.position.y, 1f, false)
            .SetEase(Ease.OutQuad);
        Invoke("CheckWin", 0.5f);
    }

    private void Update()
    {
        if(isPokemon == true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.x = 0;
            position.z = 0;
            transform.transform.position = position;
        }
    }

    private void CheckWin()
    {
        if(FindObjectOfType<Mold>().IsWin() == true)
        {
            menuWin.SetActive(true);
        }
        else if(FindObjectOfType<Cauldron>().CheckLoose() == true)
        {
            FindObjectOfType<Cauldron>().Loose();
        }
    }
}
