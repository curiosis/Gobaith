using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip dead;
    static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dead = Resources.Load<AudioClip>("DeadEffect");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Dead":
                audioSource.PlayOneShot(dead);
                break;
        }
    }
}
