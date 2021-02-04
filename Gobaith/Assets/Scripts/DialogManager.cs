using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay, whoTalking;
    public TextMeshProUGUI text;
    public string[] sentences;
    public int index = 0;
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public float speed;
    public string nextLevel, player, NPC;
    public bool dialog;
    public int[] chCallerIndexSentences;


    void Start()
    {
        index = 0;
        text.text = "Continue";
        whoTalking.text = NPC;
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        audioSource.PlayOneShot(audioClips[index]);
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            if (dialog)
                ChangeCaller();
            index++;
            textDisplay.text = "";
            if (index == sentences.Length - 1) text.text = "GO";
            StartCoroutine(Type());
        }
        else
            SceneManager.LoadScene(nextLevel);
    }

    void ChangeCaller()
    {
        if (whoTalking.text == player)
            whoTalking.text = NPC;
        else
            whoTalking.text = player;
    }
}
