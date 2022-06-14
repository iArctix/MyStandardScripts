using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
  
    public Canvas mainmenu;
    public Canvas Settingscan;
    public GameObject backbutton;


    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings()
    {
       mainmenu.enabled = false;
        Settingscan.enabled = true;
        backbutton.SetActive(true);
    }

    
}
