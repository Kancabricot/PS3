using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{

    private bool isGoDown = true;

    [SerializeField] float speed = 5;
    [SerializeField] float rotationSpeed = 5;

    private GameObject Cam;

    private GameObject Statue;

    private void Start()
    {

    }

    void Update()
    {
        if(isGoDown == true)
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, -speed);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector2(Input.acceleration.x * rotationSpeed, speed * 4);
        }

    }

    public void ChangeDirection()
    {
        isGoDown = false;
        Cam.GetComponent<CinemachineFramingTransposer>().m_TrackedObjectOffset.y = 5;
    }

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
        Destroy(collision.gameObject);
        life -= 1;
        if (life <= 0)
        {
            gameOverMenu.SetActive(true);
        }
    }

}
