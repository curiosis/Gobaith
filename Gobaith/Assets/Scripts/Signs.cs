using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signs : MonoBehaviour
{
    public Transform player;
    public float agroRange;

    public string popUpText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        
        if(Input.GetKeyDown(KeyCode.Space) && distance < agroRange)
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUpText);
        }

    }
}
