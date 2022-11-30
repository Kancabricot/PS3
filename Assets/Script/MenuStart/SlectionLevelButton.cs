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

    [SerializeField] GameObject statue;
    [SerializeField] GameObject arcDeTriumphe;
    [SerializeField] GameObject aqueduc;
    [SerializeField] GameObject chateauDEau;

    [SerializeField] GameObject title;
    [SerializeField] GameObject right;
    [SerializeField] GameObject left;
    [SerializeField] GameObject play;

    public static int IndexChoice = 1;

    public void GoRight()
    {
        if(group.transform.eulerAngles.y %45 == 0)
        {
            IndexChoice += 1;
            if(IndexChoice == 5)
            {
                IndexChoice = 1;
            }
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
            statue.transform.DORotate(new Vector3(0, 1980, 0), 1.5f, RotateMode.FastBeyond360)
            .SetDelay(0.5f)
            .SetEase(Ease.InQuad);

            statue.transform.DOScale(new Vector3(0, 0, 0), 1.5f)
            .SetDelay(0.5f)
            .SetEase(Ease.InQuad);

            arcDeTriumphe.transform.DOScale(new Vector3(0, 0, 0), 1f);

            aqueduc.transform.DOMoveX(100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            chateauDEau.transform.DOMoveX(-100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            title.transform.DOMoveY(100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            play.transform.DOMoveY(-100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            right.transform.DOMoveX(100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            left.transform.DOMoveX(-100, 0.5f, false)
                    .SetEase(Ease.OutQuad);

            Invoke("StartGame", 2f);
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

    private void StartGame()
    {
        SceneManager.LoadScene("MiniJeuDessin");
    }
}
