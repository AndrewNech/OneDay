using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtsText : MonoBehaviour
{
    

    private string[] Thoughts = { "Я проснулся.","Я не могу уйти, пока не выключу приборы.",
        "У меня есть немного времени поиграть.", "А почему бы и не почитать?","Сначала мне нужно позавтракать!",
        "Еще 15 минуточек.","Я что-то здесь не сделал."};
    string[,] StatusMeaning = { { "Проснулся", "Спал" }, { "Не встал", "" }, { "Встал", "Не играл" }, { "Играл", "Не читал" }, { "Читал", "" } };
    
    protected int statusNumber = 0;



    protected void ChangeStatus()
    {
       
        if (statusNumber < 5)
        {  statusNumber++; }
    }

   

    protected void ShowThought(GameObject thoughtPanel, int thoughtnumber)
    {
        thoughtPanel.SetActive(true);
        thoughtPanel.transform.Find("Text").GetComponent<Text>().text = Thoughts[thoughtnumber];
        StartCoroutine(CloseThough(thoughtPanel));
    }
    IEnumerator CloseThough(GameObject thoughtPanel)
    {
        yield return new WaitForSeconds(2f);
        thoughtPanel.SetActive(false);
    }
    protected int GetStatus()
    {
        return statusNumber;
    }

}
