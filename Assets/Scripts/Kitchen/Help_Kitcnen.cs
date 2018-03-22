using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help_Kitcnen : MonoBehaviour {

    private bool clickedObj;
    public bool eat = false;
    public Sprite[] status;
    private bool usedMicrowave;


    public void CheckObjects()
    {
        string[] objects = new string[8] { "cooker", "lamps", "sink", "teapot", "fridge", "microwave", "breakfast", "plate" };
        for (int i = 0; i < 4; i++)
        {
            clickedObj = GameObject.Find(objects[i]).GetComponent<ClickObjectKitchen>().Clicked;

            if (!clickedObj)
            {
                this.status = GameObject.Find(objects[i]).GetComponent<ClickObjectKitchen>().status;
                GameObject.Find(objects[i]).GetComponent<SpriteRenderer>().sprite = status[1];
                GameObject.Find(objects[i]).GetComponent<Animation>().Play("Pulsation");
                return;
            }
        }
        try
        {
            if (GameObject.Find(objects[7]).GetComponent<SpriteRenderer>().sprite.name == "plate_4" || GameObject.Find(objects[7]).GetComponent<SpriteRenderer>().sprite.name == "plate_4_selected")
            {
                if (GameObject.Find(objects[4]).GetComponent<Fridge>().Clicked)
                {
                    this.status = GameObject.Find(objects[6]).GetComponent<MoveBreakfast>().status;
                    GameObject.Find(objects[6]).GetComponent<SpriteRenderer>().sprite = status[1];
                    status = GameObject.Find(objects[7]).GetComponent<Plate>().status;
                    GameObject.Find(objects[7]).GetComponent<SpriteRenderer>().sprite = status[1];
                    GameObject.Find(objects[6]).GetComponent<Animation>().Play("Pulsation");
                    GameObject.Find(objects[7]).GetComponent<Animation>().Play("Pulsation");
                    return;
                }
                else
                {
                    this.status = GameObject.Find(objects[4]).GetComponent<Fridge>().status;
                    GameObject.Find(objects[4]).GetComponent<SpriteRenderer>().sprite = status[1];
                    GameObject.Find(objects[4]).GetComponent<Animation>().Play("Pulsation");
                    return;
                }
            }
        }
        catch
        {

        }
        if (!eat)
        {
            usedMicrowave = GameObject.Find("Canvas").GetComponent<GUIKitchen>().used;
            this.status = GameObject.Find(objects[5]).GetComponent<microwave>().status;

            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[0])
            {
                GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite = status[1];
                GameObject.Find(objects[5]).GetComponent<Animation>().Play("Pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[2])
            {
                GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite = status[3];
                status = GameObject.Find(objects[7]).GetComponent<Plate>().status;
                GameObject.Find(objects[7]).GetComponent<SpriteRenderer>().sprite = status[3];
                GameObject.Find(objects[7]).GetComponent<Animation>().Play("Pulsation");
                GameObject.Find(objects[5]).GetComponent<Animation>().Play("Pulsation");
                return;
            }
            this.status = GameObject.Find(objects[5]).GetComponent<microwave>().useMicrowaveImg;
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[2] && usedMicrowave == false)
            {
                GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite = status[3];
                GameObject.Find(objects[5]).GetComponent<Animation>().Play("Pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[2] && usedMicrowave == true)
            {
                GameObject.Find("Button (2)").GetComponent<Animation>().Play("Button_pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[0])
            {
                GameObject.Find("Button (1)").GetComponent<Animation>().Play("Button_pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[4])
            {
                GameObject.Find("Button (1)").GetComponent<Animation>().Play("Button_pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[6] && usedMicrowave == false)
            {
                GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite = status[7];
                GameObject.Find(objects[5]).GetComponent<Animation>().Play("Pulsation");
                return;
            }
            if (GameObject.Find(objects[5]).GetComponent<SpriteRenderer>().sprite == status[6] && usedMicrowave == true)
            {
                GameObject.Find("Button (2)").GetComponent<Animation>().Play("Button_pulsation");
                return;
            }
        }
        else
            GameObject.Find("Button").GetComponent<Animation>().Play("Button_pulsation");
    }
}
