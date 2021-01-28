using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI text;
    public string[] sentences;
    private int index;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public float speed, sleep;
    public string nextLevel;

    void Start()
    {
        Sleep();
        
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        audioSource.PlayOneShot(audioClips[index]);
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            if (index == sentences.Length - 1 ) text.text = "GO";
            StartCoroutine(Type());
        }
        else
            SceneManager.LoadScene(nextLevel);
    }

    IEnumerator Sleep()
    {
        text.text = "Continue";
        yield return new WaitForSeconds(sleep);
    }
}
