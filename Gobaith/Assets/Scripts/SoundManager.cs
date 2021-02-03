using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip dead, tran, jump, apple, slimeMovement;
    public static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dead = Resources.Load<AudioClip>("DeadEffect");
        tran = Resources.Load<AudioClip>("transitionSoundEffect");
        jump = Resources.Load<AudioClip>("JumpSoundEffect");
        apple = Resources.Load<AudioClip>("appleSound");
        slimeMovement = Resources.Load<AudioClip>("slime_movement");
    }

    public static void PlaySound(string clip, float distance)
    {
        audioSource.volume = 1f;
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
            case "Apple":
                audioSource.PlayOneShot(apple);
                break;
            case "SlimeMovement":
                audioSource.volume = distance;
                audioSource.PlayOneShot(slimeMovement);
                break;

        }
    }
}
