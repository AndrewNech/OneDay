using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddInStuffKitchen : MonoBehaviour {

    public GameObject[] ObjectInStuff;
    public void AddObject(string objectname, bool status)
    {
        
        switch (objectname)
        {
            case "cooker": { ObjectInStuff[0].SetActive(status); break; }
            case "lamps": { ObjectInStuff[1].SetActive(status); break; }
            case "sink": { ObjectInStuff[2].SetActive(status); break; }
            case "teapot": { ObjectInStuff[3].SetActive(status); break; }
            case "plate": { ObjectInStuff[4].SetActive(status); break; }
          

        }
    }
}
