using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtKitchen : MonoBehaviour {

    private string[] Thoughts = { "Кто-то не экономит электричество!","Я не могу уйти, пока не выключу приборы.",
        "Но я хочу кушать.", "Это здорово, но что тут кушать?","Может откроем ее?","Еду нужно подогреть!","Вкусненько!", "В микроволновке нельзя такое греть!"};
    string[,] StatusMeaning = { { "Проснулся", "Спал" }, { "Не встал", "" }, { "Встал", "Не играл" }, { "Играл", "Не читал" }, { "Читал", "" } };

    protected int statusNumber = 0;



    public void ChangeStatus()
    {
        if (statusNumber < 5)
        { statusNumber++; }
    }



    public void ShowThought(int thoughtnumber)
    {
        gameObject.SetActive(true);
        gameObject.transform.Find("Text").GetComponent<Text>().text = Thoughts[thoughtnumber];
        StartCoroutine(CloseThough());
    }
    IEnumerator CloseThough()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
    public int GetStatus()
    {
        return statusNumber;
    }
}
