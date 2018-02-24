using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thoughts : MonoBehaviour {

    public Sprite[] cloudSprite;
    static int partCloud = 0;
    public GameObject cloud;

    IEnumerator StartCloud()
    {
        yield return new WaitForSeconds(0.7f);
        for (;partCloud<3;partCloud++)
        {
            cloud.GetComponent<SpriteRenderer>().sprite = cloudSprite[partCloud];
        }
        RepatCloud();
    }
    private void RepatCloud()
    {
        StartCoroutine(StartCloud());
    }


}
