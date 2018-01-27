using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartRoom : MonoBehaviour {

    public GameObject [] buttons;

    private int TapCount = 0;
	public void Welcome()
    {
        TapCount++;
        if (TapCount == 1)
        {
            gameObject.transform.Find("Text").GetComponent<Text>().text = "Friday";
            gameObject.transform.Find("Text (1)").GetComponent<Text>().text = "Prehistory";
            gameObject.transform.Find("TextTap").GetComponent<Text>().text = "Нажмите на этот текст, чтобы начать!";
        }
        else
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
