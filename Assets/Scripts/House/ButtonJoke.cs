using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonJoke : MonoBehaviour
{

    public GameObject communicationButtonText;
    public GameObject Background;

    public Sprite[] BackgroundSprite;

    private ButtonsText buttonsText;

    private void Start()
    {
        // buttonsText = communicationButtonText.GetComponent<ButtonsText>();
    }

    public void TapButton()
    {
        StartCoroutine(Sleep());
    }
    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(0.3f);
        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[1];
        yield return new WaitForSeconds(2f);
        GetUp();
    }
    void GetUp()
    {
        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[0];
    }
}

