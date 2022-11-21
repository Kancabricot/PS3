using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{

    public void FishTheKingButton()
    {
        SceneManager.LoadScene("FishTheKing");
    }

    public void DrawButton()
    {
        SceneManager.LoadScene("MiniJeuDessin");
    }

    public void TravelBoatButton()
    {
        SceneManager.LoadScene("BoatTravel");
    }

}
