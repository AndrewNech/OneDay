using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartRoom : ThoughtsText {


    public GameObject Background;

    public Sprite[] BackgroundSprite;

    public GameObject StartPanel;
    public GameObject ThougthPanel;

    int countStartPanel = 0;



    private void Awake()
    { 
        StartCoroutine(Sleep());
    }
    IEnumerator Sleep()
    {

        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[1];
        yield return new WaitForSeconds(0.7f);
        GetUp();
    }
    void GetUp()
    {
        
        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[0];
        OpenStartPanel();
    }
    public void OpenStartPanel()
    {
        StartPanel.SetActive(true);
    }
    public void CloseStartPanel()
    {
        StartPanel.SetActive(false);
        if(countStartPanel ==0)
        ShowThought(ThougthPanel, 0);
        countStartPanel++;
    }
}