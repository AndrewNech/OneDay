using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    public GameObject FistTextPanel;

    private bool clicked = false;
    public Sprite [] status;
   
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
        if(clicked)
        gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
    }
    public void OnMouseDown()
    {
        if (!FistTextPanel.activeSelf)
        {
            clicked = !clicked;
            if (clicked)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = status[1];
            }
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
        }
    }

}
