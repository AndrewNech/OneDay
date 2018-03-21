using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPan : MonoBehaviour {

    private Vector3 startPos;
    bool clicked = false;

    private void OnMouseDown()
    {
        if (clicked == false)
        {
            startPos = gameObject.transform.position;
            clicked = true;
        }
    }
    private void OnMouseDrag()
    {
        StopCoroutine(Back());
    }

    private void OnMouseExit()
    {
        StartCoroutine(Back());
    }
    IEnumerator Back()
    {
        yield return new WaitForSeconds(2f);
        gameObject.transform.position = startPos;
        
    }
}
