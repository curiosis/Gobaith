using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public static float time = 0;
    public Text timeText;
    public static bool timing = true;

    // Update is called once per frame
    void Update()
    {
        if (timing)
            time += Time.deltaTime;
        if (!LevelLoader.nextLevel)
            timeText.text = time.ToString("0.0");
        else
            timeText.text = "";

    }
}
