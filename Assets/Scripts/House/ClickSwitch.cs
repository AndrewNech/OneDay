using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSwitch : MonoBehaviour {

    private bool clicked = false;

    public Sprite[] status;
    public Sprite[] ChandelierStatus;

    public GameObject Chandelier;
    public GameObject StuffPanel;

    AddInStuff addinstuff;

    private void Start()
    {
        addinstuff = StuffPanel.GetComponent<AddInStuff>();
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
                Chandelier.transform.position = new Vector3(Chandelier.transform.position.x, 4.217f,Chandelier.transform.position.z);
            }

        }
        else
        { gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
            Chandelier.GetComponent<SpriteRenderer>().sprite = ChandelierStatus[0];
            Chandelier.transform.position = new Vector3(
                Chandelier.transform.position.x, 3.197495f, Chandelier.transform.position.z);
        }
        addinstuff.AddObject(gameObject.name, clicked);
    }

    }


