using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonForMenu : MonoBehaviour
{
    public void FishTheKingToMenu()
    {
        CallMenu();
    }

    public void DrawToMenu()
    {
        CallMenu();
    }

    public void TettrisToMenu()
    {
        CallMenu();
    }

    private void CallMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
