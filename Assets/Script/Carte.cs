using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Carte : MonoBehaviour
{

    private float cooldown = 0;

    [SerializeField] float cooldownManager;

    [SerializeField] GameObject HUD;
    [SerializeField] GameObject TUTO;

    void Start()
    {

        cooldown = cooldownManager;
    }

    void Update()
    {
        if (cooldown < 0)
        { 
            HUD.SetActive(true);
            TUTO.SetActive(true);
            Destroy(gameObject);
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
}
