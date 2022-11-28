using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    [SerializeField] GameObject menuGameOver;

    private float heat = 0;

    [SerializeField] GameObject aiguille;
    [SerializeField] GameObject lever;
    [SerializeField] float looseCondition = 200;
    [SerializeField] float winCondition = 100;
    private bool isHeatWin = false;

    private void Update()
    {
        aiguille.transform.eulerAngles = new Vector3( 0f, 0f, -heat);

        if(heat > 20)
        {
            heat -= 0.05f;
        }
        
        if(heat > 110 && heat < 150)
        {

            if (winCondition < 0 && isHeatWin == false)
            {
                isHeatWin = true;
                FindObjectOfType<Levier>().BegenningLever();
                FindObjectOfType<Souffleur>().ExitMesh();

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

        if(isHeatWin == true && lever.transform.position.y <= 0)
        {
            transform.eulerAngles = new Vector3( lever.transform.position.y * 20, 0f, 0f);
        }

    }
    public void IncreaseHeat()
    {
        heat += 10;
        //FindObjectOfType<Levier>().BegenningLever();
        //FindObjectOfType<Souffleur>().ExitMesh();

    }
}
