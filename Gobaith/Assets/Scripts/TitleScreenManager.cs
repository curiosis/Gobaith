using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public string
        startGame,
        test;
	
	public GameObject about;

    public string[] levelList;
    public Text scores;

    private void Update()
    {
        scores.text = "Score: " + PlayerPrefs.GetInt("scoreAll");
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("deadVal", 0);
        PlayerPrefs.SetInt("deadValAll", 0);
        PlayerPrefs.SetInt("res", 0);
        PlayerPrefs.SetInt("apple", 0);
        PlayerPrefs.SetInt("scoreAll",0);
        Chapter2.enableCh2 = false;
        SceneManager.LoadScene(startGame);
    }

    public void ShowChapters()
    {
        if (!Chapter1.showChapters && !Chapter2.showChapters2)
        {
            Chapter1.OpenCh1();
            Chapter2.OpenCh2();
        }
        else
        {
            Chapter1.CloseCh1();
            Chapter2.CloseCh2();
        }
    }

    public void Chapters1(){
        SceneManager.LoadScene(levelList[0]);
    }

    public void Chapters2(){
        SceneManager.LoadScene(levelList[1]);
    }

    public void Tests()
    {
        SceneManager.LoadScene(test);
    }

    public void Quit()
    {
        Application.Quit();
    }
	
	public void About()
	{
		if (about.activeSelf == true)
			about.SetActive(false);
		else
			about.SetActive(true);
	}
}
