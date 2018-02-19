using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    public Sprite[] backgroundStart;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Image>().sprite = backgroundStart[1];
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Image>().sprite = backgroundStart[0];
    }
}
