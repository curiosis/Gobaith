using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip dead, tran, jump;
    public static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dead = Resources.Load<AudioClip>("DeadEffect");
        tran = Resources.Load<AudioClip>("transitionSoundEffect");
        jump = Resources.Load<AudioClip>("JumpSoundEffect");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Jump":
                audioSource.PlayOneShot(jump);
                break;
            case "Dead":
                audioSource.PlayOneShot(dead);
                break;
            case "TranEffect":
                audioSource.PlayOneShot(tran);
                break;

        }
    }
}
