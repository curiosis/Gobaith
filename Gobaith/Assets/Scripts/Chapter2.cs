using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2 : MonoBehaviour
{
    public static Animator animator;
    public static bool showChapters2, enableCh2;

    void Start()
    {
        animator = GetComponent<Animator>();
        showChapters2 = false;
    }

    public static void OpenCh2()
    {
        if (enableCh2)
        {
            animator.SetBool("openChMM", true);
            showChapters2 = true;
        }
    }

    public static void CloseCh2()
    {
        animator.SetBool("openChMM", false);
        showChapters2 = false;
    }
}