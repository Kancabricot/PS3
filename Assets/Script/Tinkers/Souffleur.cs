using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Souffleur : MonoBehaviour
{
    [SerializeField] GameObject termo;
    [SerializeField] GameObject mold;
    [SerializeField] GameObject bar;
    [SerializeField] SpriteRenderer soufflet;
    [SerializeField] Sprite souffletUp;
    [SerializeField] Sprite souffletDown;

    private void OnMouseDown()
    {
        soufflet.sprite = souffletDown;
        FindObjectOfType<Cauldron>().IncreaseHeat();
    }

    private void OnMouseUp()
    {
        soufflet.sprite = souffletUp;
    }

    public void ExitMesh()
    {
        transform.DOMoveY(transform.position.y + transform.position.y, 1f, false)
                    .SetEase(Ease.OutQuad);

        termo.transform.DOMoveY(transform.position.x - 8, 1f, false)
                    .SetEase(Ease.OutQuad);

        bar.transform.DOMoveY(transform.position.x + 8, 1f, false)
                    .SetEase(Ease.OutQuad);

        mold.transform.DOMoveY(-6.69f, 1f, false)
                    .SetEase(Ease.OutQuad);
    }
}
