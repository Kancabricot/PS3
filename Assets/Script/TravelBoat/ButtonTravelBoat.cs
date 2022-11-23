using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ButtonTravelBoat : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("BoatTravel");
    }
}
