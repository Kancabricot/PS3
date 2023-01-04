using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;

public class TouchDraw : MonoBehaviour
{
    Coroutine drawing;
    [SerializeField] GameObject burinMarteau; 
    [SerializeField] Image burin;
    [SerializeField] float maxDistance;

    private float distanceDo = 0;
    private bool canDraw = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canDraw == true)
        {
            StartLine();
        }
        if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
        burin.fillAmount = distanceDo / maxDistance;
    }

    public void DesactiveDraw()
    {
        canDraw = false;
    }

    void StartLine()
    {
        if(drawing != null)
        {
            StopCoroutine(drawing);
        }
        drawing = StartCoroutine(DrawLine());
    }

    void FinishLine()
    {
        StopCoroutine(drawing);
        burinMarteau.transform.position = new Vector3(-8.26f, 0, 3.02f);
    }

    IEnumerator DrawLine()
    {
        GameObject newGameObject = Instantiate(Resources.Load("Line") as GameObject, new Vector3(0, 0, 0), Quaternion.identity);
        LineRenderer line = newGameObject.GetComponent<LineRenderer>();
        line.positionCount = 0;

        while (true)
        {

            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.y += 0.2f;
            position.z = 0.2f;
            line.positionCount++;
            line.SetPosition(line.positionCount-1,position);
            burinMarteau.transform.position = new Vector3(position.x, position.y, 0);
            distanceDo += Time.deltaTime;
            yield return null;
        }
    }
}
