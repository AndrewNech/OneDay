using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fridge : MonoBehaviour {

    bool clicked = false;
    public Sprite[] status;

    public float shiftY = 0;
    public float shiftSelectedY = 0;
    public float shiftSelectedOpenedY = 0;
    private float startY;

    public float shiftX = 0;
    public float shiftSelectedX = 0;
    public float shiftSelectedOpenedX = 0;
    private float startX;

    public GameObject breakfast;
    // AddInStuff addinstuff;

    // public GameObject StuffPanel;

    private void Start()
    {
        startY = gameObject.transform.position.y;
        startX = gameObject.transform.position.x;
        // addinstuff = StuffPanel.GetComponent<AddInStuff>();
    }
    public bool Clicked
    {
        get { return clicked; }
    }

    public void OnMouseOver()
    {
        if (clicked)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[3];
            gameObject.transform.position = new Vector3(shiftSelectedOpenedX, shiftSelectedOpenedY, -3f);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[1];
            gameObject.transform.position = new Vector3(shiftSelectedX, shiftSelectedY, -3f);
        }
    }
    public void OnMouseExit()
    {
        if (clicked)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
            gameObject.transform.position = new Vector3(shiftX, shiftY, -3f);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
            gameObject.transform.position = new Vector3(startX, startY, -3f);
        }
        }
    public void OnMouseDown()
    {

        clicked = !clicked;
        if (clicked)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
            gameObject.transform.position = new Vector3(shiftX, shiftY, -3f);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
            gameObject.transform.position = new Vector3(startX, startY, -3f);
        }
        breakfast.SetActive(!breakfast.activeSelf);

        // addinstuff.AddObject(gameObject.name, clicked);

    }

}

