using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selectstorything : MonoBehaviour
{
    public GameObject Selected;
    public GameObject Unselected;
    public Image Heart;
    [SerializeField] SpriteRenderer P1;
    [SerializeField] SpriteRenderer P2;
    public Animator spriteAnims1;
    public Animator spriteAnims2;


    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        Selected.SetActive(true);
        Unselected.SetActive(false);
        Heart.enabled = true;
        spriteAnims1.SetBool("isWalking", true);
        spriteAnims2.SetBool("isWalking", true);
    }
    private void OnMouseExit()
    {
        Selected.SetActive(false);
        Unselected.SetActive(true);
        Heart.enabled = false;
        spriteAnims1.SetBool("isWalking", false);
        spriteAnims2.SetBool("isWalking", false);
    }

}
