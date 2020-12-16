using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Image customeImage;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            customeImage.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customeImage.enabled = false;
        }
    }








}
	