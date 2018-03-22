using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {

    public Sprite[] status;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "breakfast")
        {
            Destroy(collision.gameObject);
            gameObject.GetComponent<SpriteRenderer>().sprite = status[0];
        }
    }
    private void OnMouseExit()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "plate_4_selected")
            gameObject.GetComponent<SpriteRenderer>().sprite = status[2];
        if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "plate_4_full_selected")
            gameObject.GetComponent<SpriteRenderer>().sprite = status[4];
    }
}
