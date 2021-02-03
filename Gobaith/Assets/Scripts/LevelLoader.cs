using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public static bool nextLevel;
    public Animator animator;
    public float transitionTime = 7f;

    public Text points, deathsVal, timer, level, extraPoints;

    public GameObject scoreUI;

    private void Start()
    {
        nextLevel = false;
    }
    void Update()
    {
        if (nextLevel)
            LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {

        LevelTimer.timing = false;

        float t = LevelTimer.time;
        animator.SetTrigger("Start");
        SoundManager.PlaySound("TranEffect",0);

        level.text = GameManager.levelNames[SceneManager.GetActiveScene().buildIndex - 1];
        points.text = Score.res.ToString();
        deathsVal.text = PlayerPrefs.GetInt("deadVal").ToString();
        timer.text = t.ToString("0.0") + "s";

        if (PlayerPrefs.GetInt("apple") > 0)
            extraPoints.text = "+" + (100 * SceneManager.GetActiveScene().buildIndex).ToString();
        else
            extraPoints.text = "0";


        yield return new WaitForSeconds(transitionTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FruitFollow.trig = false;
            animator.SetTrigger("End");
            PlayerPrefs.SetInt("deadVal", 0);
            PlayerPrefs.SetInt("apple", 0);
            LevelTimer.time = 0;
            LevelTimer.timing = true;
            nextLevel = false;
            if (levelIndex > 6)
                Chapter2.enableCh2 = true;
            SceneManager.LoadScene(levelIndex);

        }
    }
}
