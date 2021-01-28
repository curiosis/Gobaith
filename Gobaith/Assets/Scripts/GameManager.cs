using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static string[] levelNames = new string[10];
    public static int[] apples = new int[10];

    private void Start()
    {
        levelNames[0] = "Thickets";
        levelNames[1] = "Spiky gorge";
        levelNames[2] = "Pedestal";
        levelNames[3] = "Mountain of revelation";
        levelNames[4] = "Cave de Bélly";
	    levelNames[5] = "Tany efitra";
	    levelNames[6] = "Lohasahan'i Misty";
	    levelNames[7] = "Grotta tar-ramel";
	    levelNames[8] = "Havoana rahona";
	    levelNames[9] = "Tany manidina";

        apples[0] = 1;
    }
}
