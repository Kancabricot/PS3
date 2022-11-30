using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoCanvas : MonoBehaviour
{
    [SerializeField] GameObject tuto;


    public void OnclickTuto()
    {
        Destroy(tuto);
    }
}
