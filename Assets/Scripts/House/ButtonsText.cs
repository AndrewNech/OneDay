using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ButtonsText : MonoBehaviour {

    private string json;
    TextRoom textroom = new TextRoom();
    public GameObject[] buttons;
    

    private void Start()
    {
        TextLoad();
    }
    public void SetText(int indexButton,int indextText)
    {
        buttons[indexButton].transform.Find("Text").GetComponent<Text>().text = textroom.buttonjoke[indextText];
    }



    void TextLoad()
    {
        json = File.ReadAllText(Application.streamingAssetsPath + "/Text/Roombutton.json");
        textroom = JsonUtility.FromJson<TextRoom>(json);
    }

}
public class TextRoom
{
    public string[] buttonjoke;
}
