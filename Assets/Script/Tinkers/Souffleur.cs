using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Souffleur : MonoBehaviour
{
    [SerializeField] GameObject termo;
    [SerializeField] GameObject mold;

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(1, 0.2f, 1);
        FindObjectOfType<Cauldron>().IncreaseHeat();
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1, 0.7f, 1);
    }

    public void ExitMesh()
    {
        transform.DOMoveY(transform.position.y + transform.position.y, 1f, false)
                    .SetEase(Ease.OutQuad);

        termo.transform.DOMoveY(transform.position.x - 8, 1f, false)
                    .SetEase(Ease.OutQuad);

        mold.transform.DOMoveY(transform.position.x - 8, 1f, false)
                    .SetEase(Ease.OutQuad);
    }
}
