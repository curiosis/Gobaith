using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string restartLevel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(restartLevel);
            FruitFollow.trig = false;
        }
    }

    public static void NextLevel(string nextLevel)
    {
        if (FruitFollow.trig)
            Debug.Log("Zebrany");
        SceneManager.LoadScene(nextLevel);
    }

}
