using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    [SerializeField] GameObject menuGameOver;

    private float heat = 0;

    [SerializeField] GameObject aiguille;
    [SerializeField] float looseCondition = 200;
    [SerializeField] float winCondition = 100;

    private void Update()
    {
        aiguille.transform.eulerAngles = new Vector3( 0f, 0f, -heat);
        if(heat > 20)
        {
            heat -= 0.05f;
        }
        
        if(heat > 110 && heat < 150)
        {

            if (winCondition < 0)
            {
                Debug.Log("win");
            }
            else
            {
                winCondition -= Time.deltaTime;
            }
        } else if(heat > 150)
        {
            if (looseCondition < 0)
            {
                menuGameOver.SetActive(true);
            }
            else
            {
                looseCondition -= Time.deltaTime;
            }
        }

    }
    public void IncreaseHeat()
    {
        heat += 10;
    }
}
