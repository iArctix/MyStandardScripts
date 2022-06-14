using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerchange : MonoBehaviour
{
    //Chars
    public GameObject player1;
    public GameObject player2;

    //Icons 
    public GameObject player1on;
    public GameObject player2on;

    //Player Switch Bool
    public bool isplayer1;

    //Character Walking Bug Fix
    public testmovement lew;
    public testmovement dani;


    //Switches to Player 1 on Start
    private void Awake()
    {
        SwitchPlayerOne();
    }

    //Switching
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && (isplayer1 == true) )
        {
            SwitchPlayerTwo();
        }
        else if (Input.GetKeyDown(KeyCode.Return) && (isplayer1 == false))
        {
            SwitchPlayerOne();
        }
    }

    //Switching Code
    public void SwitchPlayerOne()
    {
        dani.SendMessage("StopWalking");
        player1.GetComponent<testmovement>().enabled = true;
        player2.GetComponent<testmovement>().enabled = false;
        isplayer1 = true;
        player1on.SetActive(true);
        player2on.SetActive(false);
    }
    public void SwitchPlayerTwo()
    {
        lew.SendMessage("StopWalking");
        player1.GetComponent<testmovement>().enabled = false;
        player2.GetComponent<testmovement>().enabled = true;
        isplayer1 = false;
        Debug.Log("Switch to 2");
        player1on.SetActive(false);
        player2on.SetActive(true);
    }
}
