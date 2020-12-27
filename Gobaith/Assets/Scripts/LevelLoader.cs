using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public static bool nextLevel;
    public Animator animator;
    public float transitionTime = 3f;

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
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        animator.SetTrigger("End");
        SceneManager.LoadScene(levelIndex);
    }
}
