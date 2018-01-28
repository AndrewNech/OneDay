using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJoke : MonoBehaviour {

    public GameObject communicationButtonText;

    private ButtonsText buttonsText;

    private void Start()
    {
        buttonsText = communicationButtonText.GetComponent<ButtonsText>();
    }

    public void TapButton()
    {

    }
}
