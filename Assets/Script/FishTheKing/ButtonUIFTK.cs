using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUIFTK : MonoBehaviour
{
    public void ButtonHome()
    {
        SceneManager.LoadScene("Menu");
    }
}
