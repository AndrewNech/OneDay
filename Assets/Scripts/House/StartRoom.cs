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
            gameObject.transform.Find("Text").GetComponent<Text>().text = "Сегодня пятница, а это значит, что тебя ждет не легкий день.";
            gameObject.transform.Find("Text (1)").GetComponent<Text>().text =  "\nПервым твоим заданием будет доказать, что ты знаешь в каком состоянии должны быть приборы перед уходом.";
            gameObject.transform.Find("TextTap").GetComponent<Text>().text = "Нажми на этот текст, чтобы начать!";
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
