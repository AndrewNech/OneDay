using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour {
    
    public GameObject[] ObjectInScene;

    private ClickObject [] checkgameObjeck;
    private ClickSwitch clickSwitch;

    private void Start()
    {
        checkgameObjeck = new ClickObject[ObjectInScene.Length-1];
        for(int i = 0; i < ObjectInScene.Length; i++)
        {
            checkgameObjeck[i] = ObjectInScene[i].GetComponent<ClickObject>();
        }
        clickSwitch = ObjectInScene[ObjectInScene.Length - 1].GetComponent<ClickSwitch>();
    }
    public void CheckGameObject()
    {
        bool check = true;

        for(int i=0;i< checkgameObjeck.Length; i++)
        {
            if(!checkgameObjeck[i].Clicked)
            {
                check = false;
                break;
            }
        }
        if (!clickSwitch.Clicked)
        {
            check = false;
        }
        if (check)
            print("You are the best!");
    }

}
