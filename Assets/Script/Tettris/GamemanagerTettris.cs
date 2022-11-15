using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamemanagerTettris : MonoBehaviour
{
    [SerializeField] Transform SpawnerTransform;
    [SerializeField] GameObject Cube;

    public void NewObject()
    {
        Instantiate(Cube, SpawnerTransform.position, transform.rotation);
    }
}
