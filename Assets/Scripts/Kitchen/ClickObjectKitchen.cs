using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObjectKitchen : MonoBehaviour {

    public bool Clicked = false;

    public void OnMouseDown()
    {
        Clicked = !Clicked;
    }
}
