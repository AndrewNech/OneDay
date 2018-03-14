using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIKitchen : MonoBehaviour
{
    AddInStuffKitchen addinstuff;
    microwave smicrowave;
    ThoughtKitchen thought;
    public GameObject thoughtPanel;
    public GameObject microwave;
    public GameObject taskPanel;
    public GameObject StuffPanel;
    public GameObject background;
    public GameObject fridge;
    public GameObject[] stuffVisible;
    public GameObject[] pan;

    public Sprite boyEat;

    bool heatedFull = false;
    private bool heatedEmpty = false;
    private void Start()
    {
        thought = thoughtPanel.GetComponent<ThoughtKitchen>();
        addinstuff = StuffPanel.GetComponent<AddInStuffKitchen>();
        thought.ShowThought(0);
        smicrowave = microwave.GetComponent<microwave>();
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
           
            if (fridge.GetComponent<SpriteRenderer>().sprite.name == "fridge_closed")
            {
              SceneManager.LoadScene(4);
            }
            else
            {
                thought.ShowThought(8);
            }
           
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
        if (microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_empty_in_microwave_off")
        {
            smicrowave.WorkingMicrowave(0);
            heatedEmpty = true;
           
        }
        else if (microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_full_in_microwave_off")
        {
            smicrowave.WorkingMicrowave(1);
            heatedFull = true;
        }

    }

    public void button3_click()
    {
        if (microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_full_in_microwave_open" || microwave.GetComponent<SpriteRenderer>().sprite.name == "plate_empty_in_microwave_open")
        {
            if (heatedFull)
            {
                thought.ShowThought(6);
                addinstuff.AddObject("plate", true);
                background.GetComponent<SpriteRenderer>().sprite = boyEat;
                smicrowave.ChangeImgAfterEating();
                for (int i = 0; i < pan.Length; i++)
                {
                    pan[i].SetActive(false);
                }
                

            }
            else if (heatedEmpty)
            {
                thought.ShowThought(3);
                StartCoroutine(smicrowave.Repeat());
            }
        }

        else
        {
            thought.ShowThought(5);
        }
    }
}
