using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObjectKitchen : MonoBehaviour
{

    bool clicked = false;
    public Sprite[] status;

    public float shiftY = 0;
    private float startY;

    public float shiftX = 0;
    private float startX;

    public GameObject stuffPanel;
    AddInStuffKitchen stuffPanelScript;

    // AddInStuff addinstuff;

    // public GameObject StuffPanel;

    private void Start()
    {
        startY = gameObject.transform.position.y;
        startX = gameObject.transform.position.x;

        try
        {
            stuffPanelScript = stuffPanel.GetComponent<AddInStuffKitchen>();
        }
        catch { }
    }
    public bool Clicked
    {
        get { return clicked; }
    }

    public void OnMouseOver()
    {
        if (clicked)
            gameObject.GetComponent<SpriteRenderer>().sprite = status[3];
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = status[1];
    }
    public void OnMouseExit()
    {
        if (clicked)
            gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
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

        try
        {
            stuffPanelScript.AddObject(gameObject.name, clicked);
        }
        catch { }
        // addinstuff.AddObject(gameObject.name, clicked);
    }

}