using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] GameObject levelSelection;
    [SerializeField] GameObject Menu;

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

    public void MeltStatue()
    {
        SceneManager.LoadScene("TinkerConstruct");
    }

    public void OpenLevelSelector()
    {
        levelSelection.SetActive(true);
    }

    public void CloseLevelSelector()
    {
        levelSelection.SetActive(false);
    }

    public void CloseMenu()
    {
        Menu.SetActive(false);
    }

    public void OpenMenu()
    {
        Menu.SetActive(true);
    }
}
