using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TouchDraw : MonoBehaviour
{
    Coroutine drawing;
    [SerializeField] GameObject burinMarteau;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartLine();
        }
        if (Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }
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
            position.y += 1;
            position.z = 1;
            line.positionCount++;
            line.SetPosition(line.positionCount-1,position);
            burinMarteau.transform.position = new Vector3(position.x, position.y, 0);
            yield return null;
        }
    }
}
