using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    private float startX, startY, startZ;
   

    private void Start()
    {
        startX = gameObject.transform.position.x;
        startY = gameObject.transform.position.y;
        startZ = gameObject.transform.position.z;
    }
    void OnMouseDrag()
    {
        Vector2 p = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        gameObject.transform.position = p;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -4f);
        startX = gameObject.transform.position.x;
        startY = gameObject.transform.position.y;
        startZ = gameObject.transform.position.z;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(startX, startY, startZ);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        gameObject.transform.position = new Vector3(startX, startY,startZ);
    }

}