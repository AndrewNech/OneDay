using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ButtonsText : MonoBehaviour {

    private string json;
    TextRoom textroom = new TextRoom();


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
