using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static string[] levelNames = new string[13];
    public static int[] apples = new int[10];

    private void Start()
    {
        levelNames[0] = "";

        levelNames[1] = "Thickets";
        levelNames[2] = "Spiky gorge";
        levelNames[3] = "Pedestal";
        levelNames[4] = "Mountain of revelation";
        levelNames[5] = "Cave de Bélly";

        levelNames[6] = "";

	    levelNames[7] = "Tany efitra";
	    levelNames[8] = "Lohasahan'i Misty";
	    levelNames[9] = "Grotta tar-ramel";
	    levelNames[10] = "Havoana rahona";
	    levelNames[11] = "Tany manidina";

        levelNames[12] = "";

        apples[0] = 1;
    }
}
