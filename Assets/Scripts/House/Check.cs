using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour {

    public GameObject[] ObjectInScene;
    public GameObject HelpPanel;

    private ClickObject[] checkgameObjeck;
    private ClickSwitch clickSwitch;

    private bool MoveHelpPanel = false;

    private void Awake()
    {
        HelpPanel.transform.position = new Vector3(-13f, HelpPanel.transform.position.y, HelpPanel.transform.position.z);
    }
    private void Start()
    {
        checkgameObjeck = new ClickObject[ObjectInScene.Length - 1];
        for (int i = 0; i < ObjectInScene.Length - 1; i++)
        {
            checkgameObjeck[i] = ObjectInScene[i].GetComponent<ClickObject>();
        }
        clickSwitch = ObjectInScene[ObjectInScene.Length - 1].GetComponent<ClickSwitch>();
        
    }
    public bool CheckGameObject()
    {
        bool check = true;
        for (int i = 0; i < checkgameObjeck.Length; i++)
        {
            if (!checkgameObjeck[i].Clicked)
            {
                check = false;
                break;
            }
        }
        if (!clickSwitch.Clicked)
        {
            check = false;
        }
        return check;
    }
    public void GoKitchen()
    {

        if (CheckGameObject())
            SceneManager.LoadScene(3);
        else
            StartCoroutine(MoveRightHelpPanel());
            
            
    }
   
    IEnumerator MoveRightHelpPanel ()
    {
        if (HelpPanel.transform.position.x < -3.8f)
        {
            HelpPanel.transform.position = Vector3.Lerp(HelpPanel.transform.position, new Vector3(-3.7f, 4.2f, HelpPanel.transform.position.z), 5f * Time.deltaTime);
            yield return new WaitForSeconds(0);
            RepeatRight();
        }
        else
        {
            yield return new WaitForSeconds(1.5f);
            RepeatLeft();
        }
    }
    IEnumerator MoveleftHelpPanel()
    {
        if (HelpPanel.transform.position.x > -12)
        {
            HelpPanel.transform.position = Vector3.MoveTowards(HelpPanel.transform.position, new Vector3(-12, 4.2f, HelpPanel.transform.position.z), 5f * Time.deltaTime);
            yield return new WaitForSeconds(0);
            RepeatLeft();
        }
        

    }
    void RepeatRight()
    {
            StartCoroutine(MoveRightHelpPanel());
        
    }
    void RepeatLeft()
    {
        StartCoroutine(MoveleftHelpPanel());
    }


}
