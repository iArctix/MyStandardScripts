using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyBlock : MonoBehaviour
{
    private Rigidbody2D heavyblock;
    void Start()
    {
        heavyblock = gameObject.GetComponent<Rigidbody2D>();

        heavyblock.bodyType = RigidbodyType2D.Dynamic;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<testmovement>().bigStength == true)
        {
            heavyblock.bodyType = RigidbodyType2D.Dynamic;
        }
        if (collision.gameObject.GetComponent<testmovement>().bigStength == false)
        {
            heavyblock.bodyType = RigidbodyType2D.Static;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<testmovement>().bigStength == false)
        {
            heavyblock.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
