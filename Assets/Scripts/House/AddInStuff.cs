using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddInStuff : MonoBehaviour {

    

    public GameObject [] ObjInStuff;

    public void AddObject(string objectname, bool status)
    {
        switch (objectname)
            {
                case "Computer": { ObjInStuff[0].SetActive(status); break; }
                case "Lamp": { ObjInStuff[1].SetActive(status); break; }
                case "FloorLamp": { ObjInStuff[2].SetActive(status); break; }
                case "Switch": { ObjInStuff[3].SetActive(status); break; }
                case "LampWall": { ObjInStuff[4].SetActive(status); break; }
                case "Phone": { ObjInStuff[5].SetActive(status); break; }

        }
    }
    
}
