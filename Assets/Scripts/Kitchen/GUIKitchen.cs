using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIKitchen : MonoBehaviour
{

    ThoughtKitchen thought;
    public GameObject thoughtPanel;
    public GameObject microwave;

    public GameObject StuffPanel;

    AddInStuffKitchen addinstuff;

    public GameObject[] stuffVisible;
    public GameObject taskPanel;

    bool heatedFull = false;
    private bool heatedEmpty = false;
    private void Start()
    {
        thought = thoughtPanel.GetComponent<ThoughtKitchen>();
        addinstuff = StuffPanel.GetComponent<AddInStuffKitchen>();
        thought.ShowThought(0);
    }
   

    public void bQuestion_click()
    {
        taskPanel.SetActive(true);
    }
    public void bOk_click()
    {
        taskPanel.SetActive(false);
    }

    public void button1_click()
    {
        bool plate = false;
        int countStuff = 0;
        foreach (GameObject g in stuffVisible)
        {
            if (g.activeSelf == true)
                countStuff++;
            else if(g.name == "stuff_plate_full")
            {
                plate = true;
            }
        }
        if (countStuff == 5)
        {
            SceneManager.LoadScene(4);
        }
        else if(plate)
        {
            thought.ShowThought(2);
        }
        else
        {
            thought.ShowThought(1);
        }
    }

    public void button2_click()
    {
        if (microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_empty_in_microwave")
        {
            heatedEmpty = true;
        }
        else if (microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_full_in_microwave")
        {
            heatedFull = true;
        }

    }
    public void button3_click()
    {
        if (heatedFull)
        {
            thought.ShowThought(6);
            addinstuff.AddObject("plate", true);
        }
        else if (heatedEmpty)
        {
            thought.ShowThought(3);
        }
        else
        {
            thought.ShowThought(5);
        }
    }
}
