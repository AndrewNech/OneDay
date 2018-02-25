using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    public GameObject Story;
    public GameObject IntroText;

    public Sprite[] StoryPictures;

    private string intro;

    private Intro storyintro = new Intro();

    private int countFrames = 1;

    private void Start()
    {
        LangLoad();
        IntroText.GetComponent<Text>().text = storyintro.story[0];
    }
    private void LangLoad()
    {
        intro = File.ReadAllText(Application.streamingAssetsPath + "/Text/Intro.json");
        storyintro = JsonUtility.FromJson<Intro>(intro);
    }


    public void LeftButtonTap()
    {
        LoadPicture();
        if(countFrames>1)
        countFrames--;
    }
    public void RightButtonTap()
    {
        countFrames++;
        if (countFrames == 4)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            LoadPicture();
        }
    }
    private void LoadPicture()
    {
        switch (countFrames)
        {
            case 1: { Story.GetComponent<SpriteRenderer>().sprite = StoryPictures[0];
            IntroText.GetComponent<Text>().text = storyintro.story[0];break; }
            case 2: { Story.GetComponent<SpriteRenderer>().sprite = StoryPictures[1];
            IntroText.GetComponent<Text>().text = storyintro.story[1];break; }
            case 3: {
                    Story.GetComponent<SpriteRenderer>().sprite = StoryPictures[2];
                    IntroText.GetComponent<Text>().text = storyintro.story[2]; break; }
        }

    }
}
public class Intro
{
    public string[] story = new string[3];
}
