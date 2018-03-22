using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwave : MonoBehaviour
{

    bool clicked = false;
    public bool usingMicrowaveEmpty = false;
    public bool usingMicrowaveFull = false;

    public Sprite[] status;
    public Sprite[] useMicrowaveImg;
    public Sprite[] usedMicrowave;

    public float shiftY = 0;
    private float startY;

    public float shiftX = 0;
    private float startX;

    public GameObject thoughtPanel;
    public GameObject plate;
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
         if (collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "dripping_pan" || collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "pan")
        {
            thought.ShowThought(7);
        }
        else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "microwave_closed")
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
    public void ChangeImgAfterEating()
    {
        usingMicrowaveFull = false;
        clicked = false;
        OnMouseDown();
    }
     public IEnumerator Repeat()
    {
        yield return new WaitForSeconds(2f);
        clicked = false;
        usingMicrowaveEmpty = false;
        gameObject.GetComponent<SpriteRenderer>().sprite = ReturnImg(0);
        gameObject.transform.position = new Vector3(startX, startY, -3f);
        plate.SetActive(true);
        plate.transform.position = new Vector3(1.5f, -2.5f,-4f);
    }
    public void WorkingMicrowave(int i)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = usedMicrowave[i];
        StartCoroutine(Working(i));
    }
    IEnumerator Working(int i)
    {
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<SpriteRenderer>().sprite = usedMicrowave[i+2];
        gameObject.transform.position = new Vector3(shiftX, shiftY, -3f);
        clicked = !clicked;

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
