using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject informPanel;

	public void StartGame()
    {
        SceneManager.LoadScene(1);
        
    }
   public void LoadInformPanel()
    {
        informPanel.SetActive(!informPanel.activeSelf);
    }
}
