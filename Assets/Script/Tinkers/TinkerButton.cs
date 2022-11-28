using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TinkerButton : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("TinkerConstruct");
    }
}
