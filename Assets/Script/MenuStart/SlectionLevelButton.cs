using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;

public class SlectionLevelButton : MonoBehaviour
{
    [SerializeField] GameObject group;
    [SerializeField] GameObject WIP;
    public static int IndexChoice = 1;

    public void GoRight()
    {
        if(group.transform.eulerAngles.y %45 == 0)
        {
            IndexChoice += 1;
            group.transform.DORotate(new Vector3(0, group.transform.eulerAngles.y + 90, 0), 1.5f, RotateMode.FastBeyond360)
            .SetDelay(0.5f)
            .SetEase(Ease.OutBack);
        }
        
    }
    public void GoLeft()
    {   
        if(group.transform.eulerAngles.y % 45 == 0)
        {
            IndexChoice -= 1;
            group.transform.DORotate(new Vector3(0, group.transform.eulerAngles.y - 90, 0), 1.5f, RotateMode.FastBeyond360)
            .SetDelay(0.5f)
            .SetEase(Ease.OutBack);
        }
    }

    public void Play()
    {
        if(IndexChoice == 1)
        {
            SceneManager.LoadScene("MiniJeuDessin");
        }
        else
        {
            WIP.transform.DOMoveY(transform.position.y + 20, 0.5f, false)
                    .SetEase(Ease.OutBack);
            Invoke("WIPClose", 2f);
        }
    }

    private void WIPClose()
    {
        WIP.transform.DOMoveY(transform.position.y - 20, 0.5f, false)
                    .SetEase(Ease.OutQuad);
    }
}
