using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text time, dead, deadAll;

    void Update()
    {

        if (LevelLoader.nextLevel)
        {
            time.text = "";
            dead.text = "";
            deadAll.text = "";
        }
        if(!LevelLoader.nextLevel)
        {
            time.text = "Time: ";
            dead.text = "Deaths: ";
            deadAll.text = "All deaths: ";
        }
    }
}
