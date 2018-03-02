using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwave : MonoBehaviour {

    bool clicked = false;
    bool usingMicrowaveEmpty = false;
    bool usingMicrowaveFull = false;

    public Sprite[] status;
    public Sprite[] useMicrowaveImg;

    public float shiftY = 0;
    private float startY;

    public float shiftX = 0;
    private float startX;

    public GameObject thoughtPanel;
    ThoughtKitchen thought;
    

    private void Start()
    {
        thought = thoughtPanel.GetComponent<ThoughtKitchen>();
        startY = gameObject.transform.position.y;
        startX = gameObject.transform.position.x;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "microwave_closed")
        {
            thought.ShowThought(4);
        }
        else if (collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "plate_4")
        {
            usingMicrowaveEmpty = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = useMicrowaveImg[2];
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "plate_4_full")
        {
            usingMicrowaveFull = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = useMicrowaveImg[6];
            collision.gameObject.SetActive(false);
        }
       
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
  
    public bool Clicked
    {
        get { return clicked; }
    }

    public void OnMouseOver()
    {
            if (clicked)
                gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(3);
            else
                gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(1);
    }
    public void OnMouseExit()
    {

        if (clicked)
            gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(2);
        else
            gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(0);
    }
    public void OnMouseDown()
    {

        clicked = !clicked;
       
        
            if (clicked)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(2);
                gameObject.transform.position = new Vector3(shiftX, shiftY, -3f);
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(0);
                gameObject.transform.position = new Vector3(startX, startY, -3f);
            }
        
       
    }
    private Sprite ReturnImg(int numberImg)
    {
        if (usingMicrowaveEmpty)
        {
            return useMicrowaveImg[numberImg];
        }
        else if (usingMicrowaveFull)
        {
            return useMicrowaveImg[4 + numberImg];
        }
        else
        {
            return status[numberImg];
        }
    }
}
