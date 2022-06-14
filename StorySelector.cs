using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorySelector : MonoBehaviour
{
    public void LewDani()
    {
        SceneManager.LoadScene(3);
    }

    public void ConnorRad()
    {
        SceneManager.LoadScene(4);
    }


}
