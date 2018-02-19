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
        Story.GetComponent<SpriteRenderer>().sprite = StoryPictures[0];
        IntroText.GetComponent<Text>().text = storyintro.story[0];
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
            Story.GetComponent<SpriteRenderer>().sprite = StoryPictures[1];
            IntroText.GetComponent<Text>().text = storyintro.story[1];
        }
    }

}
public class Intro
{
    public string[] story = new string[3];
}
