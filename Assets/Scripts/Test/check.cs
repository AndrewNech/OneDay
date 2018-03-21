using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {

    public GameObject[] checkBox;
    public Sprite[] checkStatus;
    bool clicked = false;

    private void OnMouseDown()
    {
        clicked = !clicked;
       ChangeStatus(clicked,true);
    }
    private void OnMouseEnter()
    {
        ChangeStatus(clicked, true);
    }
    private void OnMouseExit()
    {
        ChangeStatus(clicked, false);
    }

    private void ChangeStatus(bool clicked, bool light)
    {
        int i = -1;
        if (clicked && light)
        {
            i = 3;
        }
        else if(clicked && !light)
        {
            i = 1;
        }
        else if(!clicked && light)
        {
            i = 2;
        }
        else
        {
            i = 0;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = checkStatus[i];
    }

}
