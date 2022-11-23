using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    
    private float heat = 0;

    [SerializeField] GameObject aiguille;

    private void Update()
    {
        aiguille.transform.eulerAngles = new Vector3( 0f, 0f, -heat);
        if(heat > 20)
        {
            heat -= 0.05f;
        }
        
    }
    public void IncreaseHeat()
    {
        heat += 10;
        Debug.Log(heat);
    }
}
