using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSwitchKitchen : MonoBehaviour {

    private bool clicked = true;

    public Sprite[] status;
    public Sprite[] ChandelierStatus;

    public GameObject Chandelier;
    public GameObject StuffPanel;

    AddInStuffKitchen addinstuff;

    private void Start()
    {
        addinstuff = StuffPanel.GetComponent<AddInStuffKitchen>();
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
            gameObject.transform.localScale = new Vector2(-0.2f, 0.2f);
        }
        else
        { gameObject.GetComponent<SpriteRenderer>().sprite = status[1];

            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
           
        }

    }
    public void OnMouseExit()
    {
        if (clicked)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
            
        }
        else
        { gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
            
        }
    }
    public void OnMouseDown()
    {
        clicked = !clicked;
        if (clicked)
        {
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = status[1];
                gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
                Chandelier.GetComponent<SpriteRenderer>().sprite = ChandelierStatus[1];
                
            }

        }
        else
        { gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
            Chandelier.GetComponent<SpriteRenderer>().sprite = ChandelierStatus[0];
         
        }
        addinstuff.AddObject(gameObject.name ,clicked);
    }

    }


