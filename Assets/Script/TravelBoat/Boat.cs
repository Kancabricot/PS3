using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    [SerializeField] float speed = 0;
    private Vector3 velocityBoat;
    [SerializeField] GameObject wheel;

    [SerializeField] float cooldownManager = 200;
    private float cooldown = 0;

    private int life = 3;
    private GameObject[] hearth;
    private bool isDomagable = true;

    [SerializeField] GameObject menuLoose;
    [SerializeField] GameObject menuWin;

    [SerializeField] private Transform savePoint;

    private void Start()
    {
        cooldown = cooldownManager;
    }

    void Update()
    {

        velocityBoat = transform.forward * speed;

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
        GetComponent<Rigidbody>().velocity = velocityBoat;

        //transform.eulerAngles = wheel.transform.eulerAngles;
        transform.eulerAngles = new Vector3(0, -wheel.transform.localEulerAngles.z, 0);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && isDomagable == true)
        {
            TP();
            life--;
            Destroy(hearth[0]);
            CheckLife();
            isDomagable=false;
        }
    }

    private void TP()
    {
        transform.position = new Vector3(savePoint.transform.position.x, transform.position.y, savePoint.transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            menuWin.SetActive(true);
            speed = 0;
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
