using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static bool count = false;
    public static int res, s;

    // Update is called once per frame
    void Update()
    {
        if (count)
        {
            Counting();
        }
    }

    public void Counting()
    {
        res = 1000 * SceneManager.GetActiveScene().buildIndex - (( PlayerPrefs.GetInt("deadVal") + (int)LevelTimer.time * SceneManager.GetActiveScene().buildIndex));
        if (res < 0)
            res = 0;

        if(PlayerPrefs.GetInt("apple")>0)
            res += 100 * SceneManager.GetActiveScene().buildIndex;
        s = PlayerPrefs.GetInt("scoreAll");
        s += res;
        PlayerPrefs.SetInt("scoreAll", s);
        count = false;
    }
}