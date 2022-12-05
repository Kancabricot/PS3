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
    [SerializeField] int BronzeIndex = 1089;
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
                Loose();
            }
            else
            {
                looseCondition -= Time.deltaTime;
            }
        }

        if(isHeatWin == true && lever.transform.position.y <= 0)
        {
            transform.eulerAngles = new Vector3( 0f, 0f, lever.transform.position.y * 30);
            //GetComponent<Rigidbody>().angularVelocity = new Vector3(lever.transform.position.y * 20, 0f, 0f);
        }

        FindObjectOfType<Bar>().Increase(winCondition);

    }
    public void IncreaseHeat()
    {
        heat += 10;
        //FindObjectOfType<Levier>().BegenningLever();
        //FindObjectOfType<Souffleur>().ExitMesh();

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BronzeMelt"))
        {
            BronzeIndex -= 1;

        }
    }

    public bool CheckLoose()
    {
        if(BronzeIndex <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Loose()
    {
        menuGameOver.SetActive(true);
    }
}
