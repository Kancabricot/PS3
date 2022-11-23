using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForMenu : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
