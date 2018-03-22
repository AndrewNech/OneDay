using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Help : MonoBehaviour {

    private bool clickedObj;
    public Sprite[] status;
    

    public void CheckObjects()
    {
        if (GameObject.Find("Canvas").GetComponent<MyGUI>().IsWakeUp)
        {
            string[] objects = new string[6] { "FloorLamp", "Lamp", "Computer", "LampWall", "Phone", "Switch" };
            for (int i = 0; i < 6; i++)
            {
                if (objects[i] == "Switch")
                    clickedObj = GameObject.Find(objects[i]).GetComponent<ClickSwitch>().Clicked;
                else
                    clickedObj = GameObject.Find(objects[i]).GetComponent<ClickObject>().Clicked;

                if (!clickedObj)
                {
                    if (objects[i] == "Switch")
                        this.status = GameObject.Find(objects[i]).GetComponent<ClickSwitch>().status;
                    else
                        this.status = GameObject.Find(objects[i]).GetComponent<ClickObject>().status;
                    GameObject.Find(objects[i]).GetComponent<SpriteRenderer>().sprite = status[1];
                    GameObject.Find(objects[i]).GetComponent<Animation>().Play("Pulsation");
                    return;
                }
            }
            GameObject.Find("ButtonKitchen").GetComponent<Animation>().Play("Button_pulsation");
        }
        else
            GameObject.Find("Button2").GetComponent<Animation>().Play("Button_pulsation");

    }
}
