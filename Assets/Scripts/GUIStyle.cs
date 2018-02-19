using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GUIStyle : MonoBehaviour
{
    public Sprite[] cover;
    private void OnMouseDown()
    {
        gameObject.GetComponent<Image>().sprite = cover[2]; 
    }
    private void OnMouseUp()
    {
        gameObject.GetComponent<Image>().sprite = cover[0];
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Image>().sprite = cover[1];
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Image>().sprite = cover[0];
    }
}

