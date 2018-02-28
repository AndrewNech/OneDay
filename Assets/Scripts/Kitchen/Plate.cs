using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour {

    public Sprite imgPlateBreakfast;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "breakfast")
        {
            collision.gameObject.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = imgPlateBreakfast;
        }
    }
}
