using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGUI : ThoughtsText
{

    public GameObject ThoughtPanel;
    public GameObject Background;
    public GameObject Chendiler;
    public GameObject mainCamera;
    public GameObject beforeGameObjectPanel;
    public GameObject boyIsReading;
    public GameObject boyIsPlaying;

    private bool isWakeUp = false;
    public GameObject[] ObjectInScene;

    public Sprite[] BackgroundSprite;

    private ButtonsText buttonsText;
    ClickObject[] ObjectScripts = new ClickObject[5];

    ClickSwitch SwitchCode;



    Check checkScript;
    private void Start()
    {
        checkScript = mainCamera.GetComponent<Check>();
        buttonsText = gameObject.GetComponent<ButtonsText>();
        for (int i = 0; i < ObjectScripts.Length - 1; i++)
        {
            ObjectScripts[i] = ObjectInScene[i].GetComponent<ClickObject>();
        }
        SwitchCode = ObjectInScene[5].GetComponent<ClickSwitch>();
    }



    public void Buton2()
    {
        isWakeUp = true;
        switch (GetStatus())
        {
            case 0:
                {
                    beforeGameObjectPanel.SetActive(false);
                    ChangeStatus();
                    ChangeStatus();
                    buttonsText.SetText(1, 3);
                    buttonsText.SetText(3, 1);
                    for (int i = 0; i < ObjectScripts.Length - 1; i++)
                    {
                        ObjectScripts[i].OnMouseDown();
                    }
                    SwitchCode.OnMouseDown();
                    Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[2];
                    Background.transform.position = new Vector2(0, 0.865f);
                    break;
                }
            case 1:
                {
                    beforeGameObjectPanel.SetActive(false);
                    ChangeStatus();
                    buttonsText.SetText(1, 3);
                    buttonsText.SetText(3, 1);
                    for (int i = 0; i < ObjectScripts.Length - 1; i++)
                    {
                        ObjectScripts[i].OnMouseDown();
                    }
                    SwitchCode.OnMouseDown();
                    Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[2];
                    Background.transform.position = new Vector2(0, 0.85f);
                    break;
                }
            default: { ShowThought(ThoughtPanel, 4); break; }

        }
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(0.3f);
        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[1];
        yield return new WaitForSeconds(2f);
        AfterSleep();
    }
    void AfterSleep()
    {
        Background.GetComponent<SpriteRenderer>().sprite = BackgroundSprite[0];
    }

    public void BInSchool()
    {
        ShowThought(ThoughtPanel, 4);
    }

    public void GoKitchen()
    {
        switch (GetStatus())
        {
            case 0: { ShowThought(ThoughtPanel, 6); break; }
            case 1: { ShowThought(ThoughtPanel, 6); break; }
            default:
                {
                    if (checkScript.CheckGameObject())
                        SceneManager.LoadScene(3);
                    else
                        ShowThought(ThoughtPanel, 1);
                    break;
                }
        }
    }

    public void BJoke()
    {
        switch (GetStatus())
        {
            case 0:
                {
                    ChangeStatus();
                    ShowThought(ThoughtPanel, 5);
                    StartCoroutine(Sleep());
                    buttonsText.SetText(3, 1);
                    break;
                }
            case 1:
                {
                    if (isWakeUp)
                    {
                        boyIsPlaying.SetActive(true);
                        ChangeStatus();
                        ChangeStatus();
                        ShowThought(ThoughtPanel, 2);
                        buttonsText.SetText(3, 2); break;
                    }
                        break;
                }
            case 2:
                {
                    boyIsPlaying.SetActive(true);
                    ChangeStatus();
                    ShowThought(ThoughtPanel, 2);
                    buttonsText.SetText(3, 2); break;
                }
            case 3:
                {
                    boyIsPlaying.SetActive(false);
                    boyIsReading.SetActive(true);
                    ChangeStatus();
                    ShowThought(ThoughtPanel, 3); break;
                }
            default:
                {
                    boyIsReading.SetActive(true);
                    ShowThought(ThoughtPanel, 4);
                    break;
                }
        }
    }
}
