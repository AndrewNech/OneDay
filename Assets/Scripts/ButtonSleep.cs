using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSleep : MonoBehaviour {

    public void BSleep()
    {
        SceneManager.LoadScene(0);
    }
	
}
