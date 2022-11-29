using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] GameObject levelSelection;

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

}
