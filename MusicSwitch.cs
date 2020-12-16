using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{

    public  AudioSource AS;
    private bool on = false;

    // Use this for initialization
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on )
        {
            AS.enabled = true;
            AS.Play();
            on = true;
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            AS.Stop();
            AS.enabled = false;
            on = false;
        }
    }
}

