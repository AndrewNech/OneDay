using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microwave : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        if (collision.gameObject.name == "plate" && gameObject.GetComponent<SpriteRenderer>().sprite.name=="microwave_open")
        {
            print("In microwave");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        collision.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
