using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    [SerializeField] float speed = 0;
    private Vector3 test;
    [SerializeField] GameObject wheel;

    [SerializeField] float cooldownManager = 200;
    private float cooldown = 0;

    private int life = 3;
    private GameObject[] hearth;
    private bool isDomagable = true;

    [SerializeField] GameObject menuLoose;
    [SerializeField] GameObject menuWin;

    private void Start()
    {
        cooldown = cooldownManager;
    }

    void Update()
    {
        test = transform.forward * speed;

        hearth = GameObject.FindGameObjectsWithTag("Hearth");

        if (isDomagable == false)
        {
            if (cooldown < 0)
            {
                isDomagable = true;
                cooldown = cooldownManager;

            }
            else
            {
                cooldown -= Time.deltaTime;
            }
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = test;

        //transform.eulerAngles = wheel.transform.eulerAngles;
        transform.eulerAngles = new Vector3(0, wheel.transform.localEulerAngles.y, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && isDomagable == true)
        {
            life--;
            Destroy(hearth[0]);
            CheckLife();
            isDomagable=false;

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            menuWin.SetActive(true);
        }
    }

    private void CheckLife()
    {
        if(life <= 0)
        {
            speed = 0;
            menuLoose.SetActive(true);
        }
    }

    public void OnStartGame()
    {
        speed = 5;
    }
}
