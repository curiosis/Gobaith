using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static string[] levelNames = new string[10];
    public static int[] apples = new int[10];

    private void Start()
    {
        levelNames[0] = "Thickets [Ithali Forest]";
        levelNames[1] = "Spiky gorge [Ithali Forest]";
        levelNames[2] = "Pedestal [Ithali Forest]";
        levelNames[3] = "Mountain of revelation";
        levelNames[4] = "Cave de Bélly [Ithali Forest]";

        apples[0] = 1;
    }
}
