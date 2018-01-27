using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour {

    private bool clicked = false;
    public Sprite [] status = new Sprite [2];
   
    public bool Clicked
    {
        get { return clicked; }
    }

    public void OnMouseDown()
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
