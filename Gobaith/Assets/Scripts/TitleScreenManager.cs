using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public string
        startGame,
        chapters,
        about,
        credits;

    public string[] levelList;

    public void StartGame()
    {
        SceneManager.LoadScene(startGame);
    }

    public void Chapter()
    {
        SceneManager.LoadScene(chapters);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
