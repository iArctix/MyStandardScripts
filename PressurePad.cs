using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePad : MonoBehaviour
{
    [SerializeField] SpriteRenderer PressureP;
    public Sprite off;
    public Sprite on;
    public GameObject activator;
    void Start()
    {
        PressureP.sprite = off;
    }
    private void Awake()
    {
        PressureP.sprite = off;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       PressureP.sprite = on;
        activator.GetComponent<Door>().SendMessage("OpenDoor");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        PressureP.sprite = off;
        activator.GetComponent<Door>().SendMessage("CloseDoor");
    }
}
