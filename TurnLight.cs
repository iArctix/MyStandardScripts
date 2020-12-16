using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{

    public GameObject Lamp;
    private bool on = false;
    public AudioSource lighton;
    public AudioSource lightoff;

    // Use this for initialization

    private void Start()
    {
        Lamp.SetActive(false);
    }




    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            Lamp.SetActive(true);
            on = true;
            lighton.Play();
            
        }
        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            Lamp.SetActive(false);
            on = false;
            lightoff.Play();

        }
    }
}