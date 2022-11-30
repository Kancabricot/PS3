using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
{
    private const float maxTemp = 10f;
    public float temperature = 0;
    private Image healthBar;

    private void Start()
    {
        healthBar = GetComponent<Image>();
    }

    private void Update()
    {
        healthBar.fillAmount = temperature / maxTemp;
    }

    public void Increase(float value)
    {
        temperature = value;
    }
}