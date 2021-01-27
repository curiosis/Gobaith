using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signs : MonoBehaviour
{
    public Transform player;
    public float agroRange;
    public GameObject popUpInfoGO;
    public Animator animator;

    public string popUpText;

    // Update is called once per frame
    void Update()
    {
        float distance = 2f;
        try
        {
            distance = Vector2.Distance(transform.position, player.position);
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            if (distance < agroRange)
            {
                PopUpInfo();
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    pop.PopUp(popUpText);
                }
            }
            else
            {
                pop.closePopUP();
                closePopUpInfo();
            }
        }
        
        catch (Exception) { }

    }

    public void PopUpInfo()
    {
        popUpInfoGO.SetActive(true);
        animator.SetBool("Info", true);
    }

    public void closePopUpInfo()
    {
        animator.SetBool("Info", false);
    }
}
