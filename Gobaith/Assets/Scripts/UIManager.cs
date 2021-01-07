using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text time, dead, deadAll;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelLoader.nextLevel)
        {
            time.text = "";
            dead.text = "";
            deadAll.text = "";
        }
    }
}
