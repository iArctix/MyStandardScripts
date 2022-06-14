using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsBackButton : MonoBehaviour
{
    public Text back;
    public Canvas mainmenu;
    public Canvas Settingscan;
    public GameObject backbutton;
        
    // Start is called before the first frame update
    void Start()
    {
        Settingscan.enabled = false;
        mainmenu.enabled = true;
        back.color = Color.white;
    }

    private void OnMouseOver()

    {
        back.color = Color.green;
        if (Input.GetMouseButtonDown(0))
        {
            Settingscan.enabled = false;
            mainmenu.enabled = true;
        }
    }

    private void OnMouseExit()
    {
        back.color = Color.white;
    }

}
