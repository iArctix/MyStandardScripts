using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouseclickscenething : MonoBehaviour
{

    public int level = 2;
    // Start is called before the first frame update
    private void OnMouseOver()
        
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(level);
        }
    }

}
