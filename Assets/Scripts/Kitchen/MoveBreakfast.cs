using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBreakfast : MonoBehaviour {

    public Sprite[] status;

    void OnMouseDrag()
    {
        Vector2 p = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        gameObject.transform.position = p;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -4f);
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = status[1];
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
    }
}
