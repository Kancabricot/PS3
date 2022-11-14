using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForMenu : MonoBehaviour
{
    public void FishTheKingToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void DrawToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
