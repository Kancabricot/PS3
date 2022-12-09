using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;

    private int life = 3;



    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Statue"))
        {
            DamageTaken(collision);
        }
    }



    public void DamageTaken(Collision collision)
    {
        //Destroy(collision.gameObject);
        life -= 1;
        if (life <= 0)
        {
            gameOverMenu.SetActive(true);
        }
    }
}
