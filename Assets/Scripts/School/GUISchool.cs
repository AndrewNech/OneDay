using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUISchool : MonoBehaviour
{

    public GameObject helpPanel;

    public GameObject thoughPanel;
    public void GoHome()
    {
        if (Slider.countSlides >= 5)
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            print(Slider.countSlides);
            thoughPanel.SetActive(true);
            StartCoroutine(ShowThought());
        }
    }
    IEnumerator ShowThought()
    {
        yield return new WaitForSeconds(3);
        thoughPanel.SetActive(false);

    }
    public void ViewHelpPanel()
    {
        helpPanel.SetActive(true);
    }
    public void CloseHelpPanel()
    {
        helpPanel.SetActive(false);
    }
}
