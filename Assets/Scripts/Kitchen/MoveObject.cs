using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    

    void OnMouseDrag()
    {
        Vector2 p = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        gameObject.transform.position = p;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -4f);
    }
   
}